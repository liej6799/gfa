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

namespace gfa_web.Purchases
{
    public class PurchaseAppService :
        CrudAppService<
            Purchase, //The Book entity
            PurchaseDto, //Used to show books
            Guid, //Primary key of the book entity
            GetPurchaseInput, //Used for paging/sorting
            CreateUpdatePurchaseDto>, //Used to create/update a book
        IPurchaseAppService //implement the IBookAppService
    {
        private readonly IVendorRepository _vendorRepository;
        
        public PurchaseAppService(IRepository<Purchase, Guid> repository,
            IVendorRepository vendorRepository) : base(repository)
        {
            _vendorRepository = vendorRepository;
        }

        public  override async Task<PurchaseDto> GetAsync(Guid id)
        {
            var queryable = await Repository.GetQueryableAsync();
            
            var query = from purchase in queryable
                join vendor in _vendorRepository on purchase.VendorId equals vendor.Id
                select new {purchase, vendor};
            var baseQuery = query.Where(x => x.purchase.Id == id);
            
            var defaultQuery = await baseQuery
                .FirstOrDefaultAsync();
            
            if (defaultQuery != null)
            {
                var result = ObjectMapper.Map<Purchase, PurchaseDto>(defaultQuery.purchase);
                result.VendorName = defaultQuery.vendor.Name;
                
                return result;
            }

            return null;
        }

        public override async Task<PagedResultDto<PurchaseDto>> GetListAsync(GetPurchaseInput input)
        {
            var queryable = await Repository.GetQueryableAsync();
            
            var query = from purchase in queryable
                join vendor in _vendorRepository on purchase.VendorId equals vendor.Id
                select new {purchase, vendor};

            var baseQuery = query.Where(x =>
                x.purchase.DatePurchase >= input.StartDate && x.purchase.DatePurchase <= input.EndDate);

            List<PurchaseDto> result;
            int resultCount;
            
            switch (input.GroupBy)
            {
                case PurchaseGroup.Vendor:
                    var vendorListQuery = await baseQuery
                        .GroupBy(x => new {x.vendor.Name, x.vendor.Id})
                        .Select(x => new
                        {
                            Source = x.Key,
                            TotalAmount = x.Sum(y => y.purchase.TotalAmount),
                            Count = x.Count()
                        })
                        .OrderBy(NormalizeSorting(input.Sorting, input.GroupBy))
                        .Skip(input.SkipCount)
                        .Take(input.MaxResultCount)
                        .ToListAsync();
                    

                    result = vendorListQuery.Select(x =>
                    {
                        var purchaseDto = new PurchaseDto
                        {
                            VendorId = x.Source.Id,
                            VendorName = x.Source.Name,
                            TotalAmount = x.TotalAmount
                        };
                        return purchaseDto;
                    }).ToList();

                    resultCount = await baseQuery
                        .GroupBy(x => new {x.vendor.Name, x.vendor.Id})
                        .CountAsync();
                    break;
                default:
                    var defaultQuery = await baseQuery
                        .OrderBy(NormalizeSorting(input.Sorting, input.GroupBy))
                        .Skip(input.SkipCount)
                        .Take(input.MaxResultCount)
                        .ToListAsync();

                    result = defaultQuery.Select(x =>
                    {
                        var purchaseDto = ObjectMapper.Map<Purchase, PurchaseDto>(x.purchase);
                        purchaseDto.VendorName = x.vendor.Name;
                        return purchaseDto;
                    }).ToList();
            
                    resultCount = await baseQuery
                        .CountAsync();
                    break;
            }
                            
            return new PagedResultDto<PurchaseDto>(
                resultCount,
                result
            );
        }
        
        private string NormalizeSorting(string sorting, PurchaseGroup purchaseGroup)
        {
            switch (purchaseGroup)
            {
                case PurchaseGroup.Vendor:
                    if (sorting.IsNullOrEmpty())
                    {
                        return $"source.{nameof(Vendor.Name)}";
                    }
                
                    if (sorting.Contains("vendorName", StringComparison.OrdinalIgnoreCase))
                    {
                        return sorting.Replace(
                            "vendorName",
                            $"source.{nameof(Vendor.Name)}", 
                            StringComparison.OrdinalIgnoreCase
                        );
                    }
                    
                    if (sorting.Contains("totalAmount", StringComparison.OrdinalIgnoreCase))
                    {
                        return sorting.Replace(
                            "totalAmount",
                            $"{nameof(Purchase.TotalAmount)}", 
                            StringComparison.OrdinalIgnoreCase
                        );
                    }
                    return $"source.{nameof(Vendor.Name)}";
                default:
                    if (sorting.IsNullOrEmpty())
                    {
                        return $"purchase.{nameof(Purchase.DatePurchase)}";
                    }
                    if (sorting.Contains("vendorName", StringComparison.OrdinalIgnoreCase))
                    {
                        return sorting.Replace(
                            "vendorName",
                            $"vendor.{nameof(Vendor.Name)}", 
                            StringComparison.OrdinalIgnoreCase
                        );
                    }
                    return $"purchase.{sorting}";
            }
        }

        public async Task<List<CreateUpdatePurchaseDto>> GetListNoPaged()
        {
            var queryable = await Repository.GetQueryableAsync();
            
            var query = from purchase in queryable
                join vendor in _vendorRepository on purchase.VendorId equals vendor.Id
                select new {purchase, vendor};
            
            var queryResult = await AsyncExecuter.ToListAsync(query);
            
            return queryResult.Select(x =>
            {
                var purchaseDto = ObjectMapper.Map<Purchase, CreateUpdatePurchaseDto>(x.purchase);
                purchaseDto.VendorSourceId = x.vendor.SourceId;
                return purchaseDto;
            }).ToList();
        }
        
        public void BatchInsert(List<CreateUpdatePurchaseDto> createUpdateVendorDto)
        {
            Repository.InsertManyAsync(ObjectMapper.Map<List<CreateUpdatePurchaseDto>, List<Purchase>>(createUpdateVendorDto));
        }
    }
}