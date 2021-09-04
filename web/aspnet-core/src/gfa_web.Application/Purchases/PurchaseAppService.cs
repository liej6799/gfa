using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using gfa_web.Vendors;
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
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdatePurchaseDto>, //Used to create/update a book
        IPurchaseAppService //implement the IBookAppService
    {
        private readonly IVendorRepository _vendorRepository;
        
        public PurchaseAppService(IRepository<Purchase, Guid> repository,
            IVendorRepository vendorRepository) : base(repository)
        {
            _vendorRepository = vendorRepository;
        }

        public override async Task<PagedResultDto<PurchaseDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            var queryable = await Repository.GetQueryableAsync();
            
            var query = from purchase in queryable
                join vendor in _vendorRepository on purchase.VendorId equals vendor.Id
                select new {purchase, vendor};
            
            var listQuery = query
                .OrderBy(NormalizeSorting(input.Sorting))
                .Skip(input.SkipCount)
                .Take(input.MaxResultCount);
            
  
            var queryResult = await AsyncExecuter.ToListAsync(listQuery);

            var purchaseDtos = queryResult.Select(x =>
            {
                var purchaseDto = ObjectMapper.Map<Purchase, PurchaseDto>(x.purchase);
                purchaseDto.VendorName = x.vendor.Name;
                return purchaseDto;
            }).ToList();


            var totalCount = await Repository.GetCountAsync();

            return new PagedResultDto<PurchaseDto>(
                totalCount,
                purchaseDtos
            );
        }

        private string NormalizeSorting(string sorting)
        {
            if (sorting.IsNullOrEmpty())
            {
                return $"purchase.{nameof(Purchase.DatePurchase)}";
            }

            if (sorting.Contains("vendorName", StringComparison.OrdinalIgnoreCase))
            {
                return sorting.Replace(
                    "vendorName",
                    "vendor.Name", 
                    StringComparison.OrdinalIgnoreCase
                );
            }

            return $"purchase.{sorting}";
           
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