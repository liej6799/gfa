using System;
using System.Collections.Generic;
using gfa_web.Vendors;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace gfa_web.Sales
{
    public class RawSaleItemAppService :
        CrudAppService<
            RawSaleItem, //The Book entity
            RawSaleItemDto, //Used to show books
            Guid, //Primary key of the book entity
            GetSaleItemInput, //Used for paging/sorting
            CreateUpdateRawSaleItemDto>, //Used to create/update a book
        IRawSaleItemAppService //implement the IBookAppService
    {
        
        public RawSaleItemAppService(IRepository<RawSaleItem, Guid> repository,
            IVendorRepository vendorRepository) : base(repository)
        {
   
        }
        
        public void BatchInsert(List<CreateUpdateRawSaleItemDto> createUpdateRawSaleItemDtos)
        {
            Repository.InsertManyAsync(ObjectMapper.Map<List<CreateUpdateRawSaleItemDto>, List<RawSaleItem>>(createUpdateRawSaleItemDtos));
        }
    }
}