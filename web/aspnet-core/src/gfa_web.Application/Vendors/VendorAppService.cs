using System;
using System.Collections.Generic;
using System.Linq;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace gfa_web.Vendors
{

    public class VendorAppService :
        CrudAppService<
            Vendor, //The Book entity
            VendorDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateVendorDto>, //Used to create/update a book
        IVendorAppService //implement the IBookAppService
    {
        public VendorAppService(IRepository<Vendor, Guid> repository) : base(repository)
        {
            
         
        }
        
        public List<CreateUpdateVendorDto> GetListNoPaged()
        {
            return ObjectMapper.Map<List<Vendor>, List<CreateUpdateVendorDto>>(Repository.ToList());
        }
        
        public void BatchInsert(List<CreateUpdateVendorDto> createUpdateVendorDto)
        {
            Repository.InsertManyAsync(ObjectMapper.Map<List<CreateUpdateVendorDto>, List<Vendor>>(createUpdateVendorDto));
        }
    }
}