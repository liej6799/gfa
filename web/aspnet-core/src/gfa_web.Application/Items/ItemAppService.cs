using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gfa_web.Purchases;
using gfa_web.Sales;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.TenantManagement;

namespace gfa_web.Items
{
    public class ItemAppService :
        CrudAppService<
            Item, //The Book entity
            ItemDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateItemDto>, //Used to create/update a book
        IItemAppService //implement the IBookAppService
    {
        
        private readonly IItemRepository _itemRepository;
        private readonly IPurchaseRepository _purchaseRepository;
        private readonly IPurchaseItemRepository _purchaseItemRepository;
        private readonly ISaleRepository _saleRepository;
        private readonly ISaleItemRepository _saleItemRepository;
        
        public ItemAppService(IRepository<Item, Guid> repository,
            IItemRepository itemRepository,
            IPurchaseRepository purchaseRepository,
            IPurchaseItemRepository purchaseItemRepository,
            ISaleRepository saleRepository,
            ISaleItemRepository saleItemRepository)
            : base(repository)
        {
            _itemRepository = itemRepository;
            _purchaseRepository = purchaseRepository;
            _purchaseItemRepository = purchaseItemRepository;
            _saleRepository = saleRepository;
            _saleItemRepository = saleItemRepository;
        }
        
        public List<CreateUpdateItemDto> GetListNoPaged()
        {
            return ObjectMapper.Map<List<Item>, List<CreateUpdateItemDto>>(Repository.ToList());
        }

        public List<CreateUpdateItemDto> GetListNoPagedFilter(GetItemInputFilter input)
        {
            return ObjectMapper.Map<List<Item>, List<CreateUpdateItemDto>>(Repository.Where(x => x.Name.Contains(input.Filter)).ToList());
        }

        public void BatchInsert(List<CreateUpdateItemDto> createUpdateItemDto)
        {
            Repository.InsertManyAsync(ObjectMapper.Map<List<CreateUpdateItemDto>, List<Item>>(createUpdateItemDto));
        }

        public async Task<PagedResultDto<ItemDto>> GetListFilterAsync(GetItemInput input)
        {
            if (input.Sorting.IsNullOrWhiteSpace())
            {
                input.Sorting = nameof(Tenant.Name);
            }

            var count = await _itemRepository.GetCountAsync(input.Filter);
            var list = await _itemRepository.GetListAsync(
                input.Sorting,
                input.MaxResultCount,
                input.SkipCount,
                input.Filter
            );

            var result = ObjectMapper.Map<List<Item>, List<ItemDto>>(list);
  
            return new PagedResultDto<ItemDto>(
                count,
                result
            );
        }
        
                
        public async Task<PagedResultDto<ItemDto>> GetQuantityTracker(GetQuantityTrackerInput input)
        {
            var queryable = await Repository.GetQueryableAsync();
            var purchaseQuery = from item in queryable
                join purchaseItem in _purchaseItemRepository on item.Id equals purchaseItem.ItemId
                join purchase in _purchaseRepository on purchaseItem.PurchaseId equals purchase.Id
                select new {purchaseItem, purchase, item};

            var filterPurchaseQuery = purchaseQuery
                .Where(u => u.item.Id == input.ItemId);
     
            
            var queryPurchaseResult = await AsyncExecuter.ToListAsync(filterPurchaseQuery);

            var saleQuery = from item in queryable
                join saleItem in _saleItemRepository on item.Id equals saleItem.ItemId
                join sale in _saleRepository on saleItem.SaleId equals sale.Id
                select new {saleItem, sale, item};

            var filterSaleQuery = saleQuery
                .Where(u => u.item.Id == input.ItemId);
        
            
            var querySaleResult = await AsyncExecuter.ToListAsync(filterSaleQuery);

            var purchaseItemDtos = queryPurchaseResult.Select(x =>
            {
                var itemDto = ObjectMapper.Map<Item, ItemDto>(x.item);
                itemDto.Quantity = Math.Abs(x.purchaseItem.Quantity);
                itemDto.Date = x.purchase.DatePurchase;
                itemDto.SalePurchaseId = x.purchase.Id;
                return itemDto;
            }).ToList();
            
            var saleItemDtos = querySaleResult.Select(x =>
            {
                var itemDto = ObjectMapper.Map<Item, ItemDto>(x.item);
                itemDto.Quantity = Math.Abs(x.saleItem.Quantity) * (-1);
                itemDto.Date = x.sale.DateSales;
                itemDto.SalePurchaseId = x.sale.Id;
                return itemDto;
            }).ToList();

            var countPurchaseQuery = purchaseQuery
                .Where(x => x.item.Id == input.ItemId);
            
            var countSaleQuery = saleQuery
                .Where(x => x.item.Id == input.ItemId);
            
            var countPurchase = await AsyncExecuter.CountAsync(countPurchaseQuery);
            var countSale = await AsyncExecuter.CountAsync(countSaleQuery);

            var combineItems = purchaseItemDtos.Concat(saleItemDtos)
                .OrderBy(x => x.Date).ToList();
            
            double remaining = 0;
            combineItems.ForEach(x =>
            {
                remaining += x.Quantity;
                x.Remaining = remaining;
            });

            return new PagedResultDto<ItemDto>(
                countPurchase + countSale,
                combineItems.Skip(input.SkipCount)
                    .Take(input.MaxResultCount).ToList()
            );
        }
        
        
    
    }
}