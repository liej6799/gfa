using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using gfa_web.Items;
using gfa_web.Vendors;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace gfa_web.Sales
{
    public class SaleAppService :
        CrudAppService<
            Sale, //The Book entity
            SaleDto, //Used to show books
            Guid, //Primary key of the book entity
            GetSaleInput, //Used for paging/sorting
            CreateUpdateSaleDto>, //Used to create/update a book
        ISaleAppService //implement the IBookAppService
    {
        private readonly IVendorRepository _vendorRepository;
        private readonly IItemRepository _itemRepository;
        private readonly ISaleItemRepository _saleItemRepository;
        public SaleAppService(IRepository<Sale, Guid> repository,
            IVendorRepository vendorRepository,
            ISaleItemRepository saleItemsRepository,
            IItemRepository itemRepository) : base(repository)
        {
            _vendorRepository = vendorRepository;
            _itemRepository = itemRepository;
            _saleItemRepository = saleItemsRepository;
        }


        public override async Task<PagedResultDto<SaleDto>> GetListAsync(GetSaleInput input)
        {
            var queryable = await Repository.GetQueryableAsync();
            
            var query = from sale in queryable
                select new {sale};

            var baseQuery = query.Where(x =>
                x.sale.DateSales.Date >= input.StartDate.Date && x.sale.DateSales.Date <= input.EndDate.Date);
            
            var vendorListQuery = await baseQuery
                .OrderBy(NormalizeSorting(input.Sorting))
                .Skip(input.SkipCount)
                .Take(input.MaxResultCount)
                .ToListAsync();
                    

            List<SaleDto> result = vendorListQuery.Select(x =>
            {
                var saleDto = new SaleDto
                {
                    Id = x.sale.Id,
                    DateSales = x.sale.DateSales,
                    TotalAmount = x.sale.TotalAmount,
                };
                return saleDto;
            }).ToList();

            int resultCount = await baseQuery
                .CountAsync();
            
            return new PagedResultDto<SaleDto>(
                resultCount,
                result
            );
        }

        public async Task<List<SaleDto>> GetListNoPaged(GetSaleInputNoPaged input)
        {
            var queryable = await Repository.GetQueryableAsync();
            
            var query = from sale in queryable
                select new {sale};

            var baseQuery = query.Where(x =>
                x.sale.DateSales.Date >= input.StartDate.Date && x.sale.DateSales.Date <= input.EndDate.Date);

            var orderedListQuery = await baseQuery
               .OrderBy(NormalizeSorting(input.Sorting))
               .ToListAsync();

            List<SaleDto> result = orderedListQuery.Select(x =>
            {
                var saleDto = new SaleDto
                {
                    Id = x.sale.Id,
                    SourceId = x.sale.SourceId,
                    DateSales = x.sale.DateSales,
                    TotalAmount = x.sale.TotalAmount,
                };
                return saleDto;
            }).ToList();

            return new List<SaleDto>(
                result
            );
        }

        public async Task<List<CreateUpdateSaleDto>> GetListNoPagedDate(GetSaleInputNoPaged input)
        {
            var queryable = await Repository.GetQueryableAsync();

            var query = from sale in queryable
                        select new { sale };

            var baseQuery = query.Where(x =>
                x.sale.DateSales.Date >= input.StartDate.Date && x.sale.DateSales.Date <= input.EndDate.Date);

            var orderedListQuery = await baseQuery
               .OrderBy(NormalizeSorting(input.Sorting))
               .ToListAsync();


            return orderedListQuery.Select(x =>
            {
                var saleDto = ObjectMapper.Map<Sale, CreateUpdateSaleDto>(x.sale);
                var shortName = String.Empty;
                foreach (var saleItem in _saleItemRepository.Where(x => x.SaleId == saleDto.Id).ToList())
                {
                    foreach(var item in _itemRepository.Where(x => x.Id == saleItem.ItemId).ToList())
                    {
                        shortName += saleItem.Quantity + "x " + item.Name + " "; 
                    }
                    
                }
                saleDto.ShortName = shortName.Trim();
                return saleDto;
            }).ToList();
        }

        public async Task<List<CreateUpdateSaleDto>> GetListNoPagedDateGroup(GetSaleDateGroupInput input)
        {
            var queryable = await Repository.GetQueryableAsync();

            var query = from sale in queryable
                        select new { sale };

            var baseQuery = query.Where(x =>
                x.sale.DateSales.Date >= input.StartDate.Date && x.sale.DateSales.Date <= input.EndDate.Date);
            
            List<CreateUpdateSaleDto> result;

            switch (input.GroupBy)
            {
                case SaleGroup.Daily:
                    var dailySaleQuery = await baseQuery
                        .GroupBy(x => new { x.sale.DateSales.Date })
                        .Select(x => new
                        {
                            Source = x.Key,
                            TotalAmount = x.Sum(y => y.sale.TotalAmount),
                            Count = x.Count()
                        })
                        .ToListAsync();


                    result = dailySaleQuery.Select(x =>
                    {
                        var saleDto = new CreateUpdateSaleDto
                        {
                            DateSales = x.Source.Date,
                            TotalAmount = x.TotalAmount,
                            Count = x.Count
                        };
                        return saleDto;
                    }).ToList();

                    break;
                case SaleGroup.Hourly:
                    var hourlySaleQuery = await baseQuery
                        .GroupBy(x => new { x.sale.DateSales.Date, x.sale.DateSales.Hour })
                        .Select(x => new
                        {
                            Source = x.Key,
                            TotalAmount = x.Sum(y => y.sale.TotalAmount),
                            Count = x.Count()
                        })
                        .ToListAsync();


                    result = hourlySaleQuery.Select(x =>
                    {
                        var saleDto = new CreateUpdateSaleDto
                        {
                            DateSales = x.Source.Date.AddHours(x.Source.Hour),
                            TotalAmount = x.TotalAmount,
                            Count = x.Count
                        };
                        return saleDto;
                    }).ToList();

                    break;
                default:
                    result = new List<CreateUpdateSaleDto>();
                    break;

            }

            return new List<CreateUpdateSaleDto>(
             result
            );
        }


        public void BatchInsert(List<CreateUpdateSaleDto> createUpdateSaleDtos)
        {
            Repository.InsertManyAsync(ObjectMapper.Map<List<CreateUpdateSaleDto>, List<Sale>>(createUpdateSaleDtos));
        }
        
        private string NormalizeSorting(string sorting)
        {
            if (sorting.IsNullOrEmpty())
            {
                return $"sale.{nameof(Sale.DateSales)}";
            }
            
            if (sorting.Contains("dateSales", StringComparison.OrdinalIgnoreCase))
            {
                return sorting.Replace(
                    "dateSales",
                    $"sale.{nameof(Sale.DateSales)}", 
                    StringComparison.OrdinalIgnoreCase
                );
            }
            
            if (sorting.Contains("totalAmount", StringComparison.OrdinalIgnoreCase))
            {
                return sorting.Replace(
                    "totalAmount",
                    $"sale.{nameof(Sale.TotalAmount)}", 
                    StringComparison.OrdinalIgnoreCase
                );
            }
            return $"sale.{nameof(Sale.DateSales)}";
        }
    }
}