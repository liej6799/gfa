using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using gfa_web.Items;
using Microsoft.EntityFrameworkCore;
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
            GetSaleItemInput, //Used for paging/sorting
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

        public override async Task<PagedResultDto<SaleItemDto>> GetListAsync(GetSaleItemInput input)
        {
            var queryable = await Repository.GetQueryableAsync();
    
            var query = from saleItem in queryable
                join sale in _saleRepository on saleItem.SaleId equals sale.Id
                join item in _itemRepository on saleItem.ItemId equals item.Id
                select new {saleItem, sale, item};
  
            var filterQuery = query
                .Where(u => u.saleItem.SaleId == input.SaleId)
                .WhereIf(
                    !input.Filter.IsNullOrWhiteSpace(),
                    u =>
                        (u.item.Name.Contains(input.Filter)))
                .OrderBy(NormalizeSorting(input.Sorting))
                .Skip(input.SkipCount)
                .Take(input.MaxResultCount);
        

            var queryResult = await AsyncExecuter.ToListAsync(filterQuery);

            var saleItemDtos = queryResult.Select(x =>
            {
                var saleItemDto = ObjectMapper.Map<SaleItem, SaleItemDto>(x.saleItem);
                saleItemDto.ItemName = x.item.Name;
                saleItemDto.SalePrice = x.saleItem.Price;
                return saleItemDto;
            }).ToList();

            var countQuery = query
                .Where(u => u.saleItem.SaleId == input.SaleId)
                .WhereIf(
                    !input.Filter.IsNullOrWhiteSpace(),
                    u =>
                        (u.item.Name.Contains(input.Filter)));

            var totalCount = await AsyncExecuter.CountAsync(countQuery);

            return new PagedResultDto<SaleItemDto>(
                totalCount,
                saleItemDtos
            );
        }

        public async Task<List<SaleItemDto>> GetListNoPaged(GetSaleItemInputFilter input)
        {
            var queryable = await Repository.GetQueryableAsync();

            var query = from saleItem in queryable
                join sale in _saleRepository on saleItem.SaleId equals sale.Id
                join item in _itemRepository on saleItem.ItemId equals item.Id
                select new { saleItem, sale, item };


            var filterQuery = query
                 .Where(u => u.saleItem.SaleId == input.SaleId)
                 .OrderBy(NormalizeSorting(input.Sorting));
  
            var queryResult = await AsyncExecuter.ToListAsync(filterQuery);

            var saleItemDtos = queryResult.Select(x =>
            {
                var saleItemDto = ObjectMapper.Map<SaleItem, SaleItemDto>(x.saleItem);
                saleItemDto.ItemName = x.item.Name;
                saleItemDto.SalePrice = x.saleItem.Price;
                return saleItemDto;
            }).ToList();

            return new List<SaleItemDto>(
                saleItemDtos
            );
        }
        public async Task<List<CreateUpdateSaleItemDto>> GetListNoPageDate(GetSaleItemDateInput input)
        {
            var queryable = await Repository.GetQueryableAsync();

            var query = from saleItem in queryable
                        join item in _itemRepository on saleItem.ItemId equals item.Id
                        join sale in _saleRepository on saleItem.SaleId equals sale.Id
                        select new { saleItem, item, sale };

            var baseQuery = query.Where(x =>
                x.sale.DateSales.Date >= input.StartDate.Date && x.sale.DateSales.Date <= input.EndDate.Date);


            var queryResult = await AsyncExecuter.ToListAsync(baseQuery);

            var result = queryResult.Select(x =>
            {
                var saleItemDto = ObjectMapper.Map<SaleItem, CreateUpdateSaleItemDto>(x.saleItem);
                saleItemDto.ItemSourceId = x.item.SourceId;
                saleItemDto.SaleSourceId = x.sale.SourceId;
                return saleItemDto;
            }).ToList();
            return result;
        }

        public async Task<List<SaleItemDto>> GetListNoPagedDateSummary(GetSaleItemDateInput input)
        {
            var queryable = await Repository.GetQueryableAsync();

            var query = from saleItem in queryable
                        join sale in _saleRepository on saleItem.SaleId equals sale.Id
                        join item in _itemRepository on saleItem.ItemId equals item.Id
                        select new { saleItem, sale, item };


            var baseQuery = query.Where(x =>
                x.sale.DateSales.Date >= input.StartDate.Date && x.sale.DateSales.Date <= input.EndDate.Date);


            var sayurQueryResult = await baseQuery
               .Where(x => x.item.Name == "Sayur")
               .GroupBy(x => new { x.item.Name, x.item.Id })
               .Select(x => new
               {
                   Source = x.Key,
                   Quantity = x.Sum(y => y.saleItem.Quantity),
                   TotalAmount = x.Sum(y => y.saleItem.Total),
                   Count = x.Count()
               }).ToListAsync();

            var queryResult = await baseQuery
                .Where(x => x.item.Name != "Sayur")
                .GroupBy(x => new { x.item.Name, x.item.Id, x.saleItem.Price })
                .Select(x => new
                {
                    Source = x.Key,
                    Quantity = x.Sum(y => y.saleItem.Quantity),
                    TotalAmount = x.Sum(y => y.saleItem.Total),
                    Count = x.Count()
                }).ToListAsync();


            var saleItemDtos = queryResult.Select(x =>
            {
                var saleItemDto = new SaleItemDto();
                saleItemDto.Price = x.Source.Price;
                saleItemDto.ItemName = x.Source.Name;
                saleItemDto.Quantity = x.Quantity;
                saleItemDto.Total = x.TotalAmount;
                return saleItemDto;
            }).ToList();

            var sayurSaleItemDtos = sayurQueryResult.Select(x =>
            {
                var saleItemDto = new SaleItemDto();
                saleItemDto.Price = 0;
                saleItemDto.ItemName = x.Source.Name;
                saleItemDto.Quantity = x.Quantity;
                saleItemDto.Total = x.TotalAmount;
                return saleItemDto;
            }).ToList();

            saleItemDtos.AddRange(sayurSaleItemDtos);

            return new List<SaleItemDto>(
               saleItemDtos
               );
            
        }

        public async Task<PagedResultDto<SaleItemDto>> GetItemHistoryAsync(GetItemHistoryInput input)
        {
            var queryable = await Repository.GetQueryableAsync();
            
            var query = from saleItem in queryable
                join sale in _saleRepository on saleItem.SaleId equals sale.Id
                join item in _itemRepository on saleItem.ItemId equals item.Id
                select new {saleItem, sale, item};


            var filterQuery = query
                .Where(u => u.item.Id == input.ItemId)           
                .OrderBy(NormalizeSorting(input.Sorting))
                .Skip(input.SkipCount)
                .Take(input.MaxResultCount);
        

            var queryResult = await AsyncExecuter.ToListAsync(filterQuery);

            var saleItemDtos = queryResult.Select(x =>
            {
                var saleItemDto = ObjectMapper.Map<SaleItem, SaleItemDto>(x.saleItem);
                saleItemDto.ItemName = x.item.Name;
                saleItemDto.CurrentBuyPrice = x.item.BuyPrice;
                saleItemDto.DateSales = x.sale.DateSales;
                saleItemDto.SaleId = x.sale.Id;
                saleItemDto.SalePrice = x.saleItem.Price;
                return saleItemDto;
            }).ToList();

            var countQuery = query
                .Where(x => x.item.Id == input.ItemId);

            var totalCount = await AsyncExecuter.CountAsync(countQuery);

            return new PagedResultDto<SaleItemDto>(
                totalCount,
                saleItemDtos
            );
        }
        
        
        public void BatchInsert(List<CreateUpdateSaleItemDto> createUpdateSaleItemDtos)
        {
            Repository.InsertManyAsync(ObjectMapper.Map<List<CreateUpdateSaleItemDto>, List<SaleItem>>(createUpdateSaleItemDtos));
        }
        
        private string NormalizeSorting(string sorting)
        {
            if (sorting.IsNullOrEmpty())
            {
                return $"item.{nameof(Item.Name)}";
            }
            
            if (sorting.Contains("dateSales", StringComparison.OrdinalIgnoreCase))
            {
                return sorting.Replace(
                    "dateSales",
                    $"sale.{nameof(Sale.DateSales)}", 
                    StringComparison.OrdinalIgnoreCase
                );
            }
            
            if (sorting.Contains("quantity", StringComparison.OrdinalIgnoreCase))
            {
                return sorting.Replace(
                    "quantity",
                    $"saleItem.{nameof(SaleItem.Quantity)}", 
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

            if (sorting.Contains("salePrice", StringComparison.OrdinalIgnoreCase))
            {
                return sorting.Replace(
                    "salePrice",
                    $"saleItem.{nameof(SaleItem.Price)}", 
                    StringComparison.OrdinalIgnoreCase
                );
            }
            
            if (sorting.Contains("total", StringComparison.OrdinalIgnoreCase))
            {
                return sorting.Replace(
                    "total",
                    $"saleItem.{nameof(SaleItem.Total)}", 
                    StringComparison.OrdinalIgnoreCase
                );
            }
            return $"item.{nameof(Item.Name)}";
        }
    }

}