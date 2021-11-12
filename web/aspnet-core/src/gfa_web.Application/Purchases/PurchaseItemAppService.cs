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
            GetPurchaseItemInput, //Used for paging/sorting
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
        public async Task<PagedResultDto<PurchaseItemDto>> GetItemHistoryAsync(GetPurchaseItemInputHistory input)
        {
            var queryable = await Repository.GetQueryableAsync();
            var query = from purchaseItem in queryable
                join purchase in _purchaseRepository on purchaseItem.PurchaseId equals purchase.Id
                join item in _itemRepository on purchaseItem.ItemId equals item.Id
                select new {purchaseItem, purchase, item};

            var filterQuery = query
                .Where(u => u.item.Id == input.ItemId)          
                .OrderBy(NormalizeSorting(input.Sorting))
                .Skip(input.SkipCount)
                .Take(input.MaxResultCount);

            var queryResult = await AsyncExecuter.ToListAsync(filterQuery);

            var purchaseItemDtos = queryResult.Select(x =>
            {
                var purchaseItemDto = ObjectMapper.Map<PurchaseItem, PurchaseItemDto>(x.purchaseItem);
                purchaseItemDto.ItemName = x.item.Name;
                purchaseItemDto.CurrentBuyPrice = x.item.BuyPrice;
                purchaseItemDto.DatePurchase = x.purchase.DatePurchase;
                purchaseItemDto.PurchaseId = x.purchase.Id;
                purchaseItemDto.BuyPrice = x.purchaseItem.Price;
                return purchaseItemDto;
            }).ToList();

            var countQuery = query
                .Where(x => x.item.Id == input.ItemId);

            var totalCount = await AsyncExecuter.CountAsync(countQuery);

            return new PagedResultDto<PurchaseItemDto>(
                totalCount,
                purchaseItemDtos
            );
        }

        public override async Task<PagedResultDto<PurchaseItemDto>> GetListAsync(GetPurchaseItemInput input)
        {
            var queryable = await Repository.GetQueryableAsync();
            var query = from purchaseItem in queryable
                join purchase in _purchaseRepository on purchaseItem.PurchaseId equals purchase.Id
                join item in _itemRepository on purchaseItem.ItemId equals item.Id
                select new {purchaseItem, purchase, item};


            var filterQuery = query
                .Where(u => u.purchaseItem.PurchaseId == input.PurchaseId)
                .WhereIf(
                    !input.Filter.IsNullOrWhiteSpace(),
                    u =>
                        (u.item.Name.Contains(input.Filter)))
                .OrderBy(NormalizeSorting(input.Sorting))
                .Skip(input.SkipCount)
                .Take(input.MaxResultCount);
        
            
            
            var queryResult = await AsyncExecuter.ToListAsync(filterQuery);

            var purchaseItemDtos = queryResult.Select(x =>
            {
                var purchaseItemDto = ObjectMapper.Map<PurchaseItem, PurchaseItemDto>(x.purchaseItem);
                purchaseItemDto.ItemName = x.item.Name;
                purchaseItemDto.BuyPrice = x.purchaseItem.Price;
                return purchaseItemDto;
            }).ToList();

            var countQuery = query
                .Where(u => u.purchaseItem.PurchaseId == input.PurchaseId)
                .WhereIf(
                    !input.Filter.IsNullOrWhiteSpace(),
                    u =>
                        (u.item.Name.Contains(input.Filter)));


            var totalCount = await AsyncExecuter.CountAsync(countQuery);

            return new PagedResultDto<PurchaseItemDto>(
                totalCount,
                purchaseItemDtos
            );
        }
        

        public async Task<List<CreateUpdatePurchaseItemDto>> GetListNoPaged(GetPurchaseItemDateInput input)
        {
            var queryable = await Repository.GetQueryableAsync();
            
            var query = from purchaseItem in queryable
                join item in _itemRepository on purchaseItem.ItemId equals item.Id
                join purchase in _purchaseRepository on purchaseItem.PurchaseId equals purchase.Id
                select new {purchaseItem, item, purchase};
            
            var baseQuery = query.Where(x =>
                x.purchase.DatePurchase.Date >= input.StartDate.Date && x.purchase.DatePurchase.Date <= input.EndDate.Date);
            
            var queryResult = await AsyncExecuter.ToListAsync(baseQuery);
            
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
            
            if (sorting.Contains("quantity", StringComparison.OrdinalIgnoreCase))
            {
                return sorting.Replace(
                    "quantity",
                    $"purchaseItem.{nameof(PurchaseItem.Quantity)}", 
                    StringComparison.OrdinalIgnoreCase
                );
            }
            
            if (sorting.Contains("itemName", StringComparison.OrdinalIgnoreCase))
            {
                return sorting.Replace(
                    "itemName",
                    $"item.{nameof(Item.Name)}", 
                    StringComparison.OrdinalIgnoreCase
                );
            }
            
            if (sorting.Contains("currentBuyPrice", StringComparison.OrdinalIgnoreCase))
            {
                return sorting.Replace(
                    "currentBuyPrice",
                    $"item.{nameof(Item.BuyPrice)}", 
                    StringComparison.OrdinalIgnoreCase
                );
            } 
            
            if (sorting.Contains("buyPrice", StringComparison.OrdinalIgnoreCase))
            {
                return sorting.Replace(
                    "buyPrice",
                    $"purchaseItem.{nameof(PurchaseItem.Price)}", 
                    StringComparison.OrdinalIgnoreCase
                );
            }
            
            if (sorting.Contains("total", StringComparison.OrdinalIgnoreCase))
            {
                return sorting.Replace(
                    "total",
                    $"purchaseItem.{nameof(PurchaseItem.Total)}", 
                    StringComparison.OrdinalIgnoreCase
                );
            }
            
            if (sorting.Contains("datePurchase", StringComparison.OrdinalIgnoreCase))
            {
                return sorting.Replace(
                    "datePurchase",
                    $"purchase.{nameof(Purchase.DatePurchase)}", 
                    StringComparison.OrdinalIgnoreCase
                );
            }

            return $"item.{nameof(Item.Name)}";
        }

        public void BatchInsert(List<CreateUpdatePurchaseItemDto> createUpdatePurchaseItemDtos)
        {
            Repository.InsertManyAsync(ObjectMapper.Map<List<CreateUpdatePurchaseItemDto>, List<PurchaseItem>>(createUpdatePurchaseItemDtos));      
        }
    }
}