using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using gfa_web.Items;
using System.Linq;
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

        public void BatchInsert(List<CreateUpdatePurchaseItemDto> createUpdatePurchaseItemDtos)
        {
            Repository.InsertManyAsync(ObjectMapper.Map<List<CreateUpdatePurchaseItemDto>, List<PurchaseItem>>(createUpdatePurchaseItemDtos));      
        }
    }
}