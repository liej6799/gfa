using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using gfa_web.Items;
using System.Linq;
using System.Linq.Dynamic.Core;
using gfa_web.Vendors;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace gfa_web.Purchases
{
    public class PurchaseItemAppService :
        CrudAppService<
            PurchaseItem, //The Book entity
            PurchaseItemDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdatePurchaseItemDto>, //Used to create/update a book
        IPurchaseItemAppService //implement the IBookAppService
    {
        
        private readonly IItemRepository _itemRepository;
        private readonly IPurchaseRepository _purchaseRepository;
        
        public PurchaseItemAppService(IRepository<PurchaseItem, Guid> repository,
            IItemRepository itemRepository,
            IPurchaseRepository purchaseRepository) : base(repository)
        {
            _itemRepository = itemRepository;
            _purchaseRepository = purchaseRepository;
        }

        public async Task<PagedResultDto<PurchaseItemDto>> GetListFilterAsync(GetPurchaseItemInput input)
        {
            var queryable = await Repository.GetQueryableAsync();
            var order = NormalizeSorting(input.Sorting);
            var query = from purchaseItem in queryable
                join purchase in _purchaseRepository on purchaseItem.PurchaseId equals purchase.Id
                join item in _itemRepository on purchaseItem.ItemId equals item.Id
                select new {purchaseItem, purchase, item};


            var filterQuery = query
                .Where(u => u.purchaseItem.PurchaseId == input.PurchaseId)           
                .Skip(input.SkipCount)
                .Take(input.MaxResultCount);
        
            
            
            var queryResult = await AsyncExecuter.ToListAsync(filterQuery);

            var purchaseItemDtos = queryResult.Select(x =>
            {
                var purchaseItemDto = ObjectMapper.Map<PurchaseItem, PurchaseItemDto>(x.purchaseItem);
                purchaseItemDto.ItemName = x.item.Name;
                return purchaseItemDto;
            }).ToList();

            var countQuery = query
                .Where(x => x.purchase.Id == input.PurchaseId);

            var totalCount = await AsyncExecuter.CountAsync(countQuery);

            return new PagedResultDto<PurchaseItemDto>(
                totalCount,
                purchaseItemDtos
            );
        }
        

        public async Task<List<CreateUpdatePurchaseItemDto>> GetListNoPaged()
        {
            var queryable = await Repository.GetQueryableAsync();
            
            var query = from purchaseItem in queryable
                join item in _itemRepository on purchaseItem.ItemId equals item.Id
                join purchase in _purchaseRepository on purchaseItem.PurchaseId equals purchase.Id
                select new {purchaseItem, item, purchase};
            
            var queryResult = await AsyncExecuter.ToListAsync(query);
            
            var result = queryResult.Select(x =>
            {
                var purchaseItemDto = ObjectMapper.Map<PurchaseItem, CreateUpdatePurchaseItemDto>(x.purchaseItem);
                purchaseItemDto.ItemSourceId = x.item.SourceId;
                purchaseItemDto.PurchaseSourceId = x.purchase.SourceId;
                return purchaseItemDto;
            }).ToList();
            return result;
        }
        
        private string NormalizeSorting(string sorting)
        {
            if (sorting.IsNullOrEmpty())
            {
                return $"item.{nameof(Item.Name)}";
            }

            if (sorting.Contains("itemName", StringComparison.OrdinalIgnoreCase))
            {
                return sorting.Replace(
                    "itemName",
                    "item.Name", 
                    StringComparison.OrdinalIgnoreCase
                );
            }
            if (sorting.Contains("price", StringComparison.OrdinalIgnoreCase))
            {
                return sorting.Replace(
                    "price",
                    "purchaseItems.price", 
                    StringComparison.OrdinalIgnoreCase
                );
            }
            
            if (sorting.Contains("quantity", StringComparison.OrdinalIgnoreCase))
            {
                return sorting.Replace(
                    "quantity",
                    "purchaseItems.quantity", 
                    StringComparison.OrdinalIgnoreCase
                );
            }
            
            if (sorting.Contains("total", StringComparison.OrdinalIgnoreCase))
            {
                return sorting.Replace(
                    "total",
                    "purchaseItems.total", 
                    StringComparison.OrdinalIgnoreCase
                );
            }


            return $"item.{sorting}";
           
        }

        public void BatchInsert(List<CreateUpdatePurchaseItemDto> createUpdatePurchaseItemDtos)
        {
            Repository.InsertManyAsync(ObjectMapper.Map<List<CreateUpdatePurchaseItemDto>, List<PurchaseItem>>(createUpdatePurchaseItemDtos));      
        }
    }
}