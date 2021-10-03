using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gfa_web.Vendors;
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

        public async Task<List<CreateUpdateSaleDto>> GetListNoPaged()
        {
            var queryable = await Repository.GetQueryableAsync();
            
            var query = from sale in queryable
                select new {sale};
            
            var queryResult = await AsyncExecuter.ToListAsync(query);
            
            return queryResult.Select(x =>
            {
                var saleDto = ObjectMapper.Map<Sale, CreateUpdateSaleDto>(x.sale);
                return saleDto;
            }).ToList();
        }

        public void BatchInsert(List<CreateUpdateSaleDto> createUpdateSaleDtos)
        {
            Repository.InsertManyAsync(ObjectMapper.Map<List<CreateUpdateSaleDto>, List<Sale>>(createUpdateSaleDtos));
        }
    }
}