using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using gfa_web.Vendors;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace gfa_web.Sales
{
    public class RawSaleAppService :
        CrudAppService<
            RawSale, //The Book entity
            RawSaleDto, //Used to show books
            Guid, //Primary key of the book entity
            GetSaleInput, //Used for paging/sorting
            CreateUpdateRawSaleDto>, //Used to create/update a book
        IRawSaleAppService //implement the IBookAppService
    {
        
        public RawSaleAppService(IRepository<RawSale, Guid> repository,
            IVendorRepository vendorRepository) : base(repository)
        {
   
        }

        public void BatchInsert(List<CreateUpdateRawSaleDto> createUpdateRawSaleDtos)
        {
            Repository.InsertManyAsync(ObjectMapper.Map<List<CreateUpdateRawSaleDto>, List<RawSale>>(createUpdateRawSaleDtos));
        }
        
    }
}