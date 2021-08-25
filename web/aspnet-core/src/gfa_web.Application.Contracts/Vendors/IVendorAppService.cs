using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace gfa_web.Vendors
{
    public interface IVendorAppService :
        ICrudAppService< //Defines CRUD methods
            VendorDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto,
            CreateUpdateVendorDto> //Used to create/update a book
    {
        List<CreateUpdateVendorDto> GetListNoPaged();
        void BatchInsert(List<CreateUpdateVendorDto> createUpdateVendorDto);
    }
}