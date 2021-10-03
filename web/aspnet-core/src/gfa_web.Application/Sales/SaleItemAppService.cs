using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gfa_web.Items;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace gfa_web.Sales
{
    public class SaleItemAppService :
        CrudAppService<
            SaleItem, //The Book entity
            SaleItemDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateSaleItemDto>, //Used to create/update a book
        ISaleItemAppService //implement the IBookAppService
    {
        
        private readonly IItemRepository _itemRepository;
        private readonly ISaleRepository _saleRepository;
        
        public SaleItemAppService(IRepository<SaleItem, Guid> repository,
            IItemRepository itemRepository,
            ISaleRepository saleRepository) : base(repository)
        {
            _itemRepository = itemRepository;
            _saleRepository = saleRepository;
        }
        

        public async Task<List<CreateUpdateSaleItemDto>> GetListNoPaged()
        {
            var queryable = await Repository.GetQueryableAsync();
            
            var query = from saleItem in queryable
                join item in _itemRepository on saleItem.ItemId equals item.Id
                join sale in _saleRepository on saleItem.SaleId equals sale.Id
                select new {saleItem, item, sale};
            
            var queryResult = await AsyncExecuter.ToListAsync(query);
            
            var result = queryResult.Select(x =>
            {
                var saleItemDto = ObjectMapper.Map<SaleItem, CreateUpdateSaleItemDto>(x.saleItem);
                saleItemDto.ItemSourceId = x.item.SourceId;
                saleItemDto.SaleSourceId = x.sale.SourceId;
                return saleItemDto;
            }).ToList();
            return result;
        }
        
        public void BatchInsert(List<CreateUpdateSaleItemDto> createUpdateSaleItemDtos)
        {
            Repository.InsertManyAsync(ObjectMapper.Map<List<CreateUpdateSaleItemDto>, List<SaleItem>>(createUpdateSaleItemDtos));      
        }
    }

}