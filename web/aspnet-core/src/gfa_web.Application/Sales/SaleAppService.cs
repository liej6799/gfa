using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
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
        
        public SaleAppService(IRepository<Sale, Guid> repository,
            IVendorRepository vendorRepository) : base(repository)
        {
            _vendorRepository = vendorRepository;
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