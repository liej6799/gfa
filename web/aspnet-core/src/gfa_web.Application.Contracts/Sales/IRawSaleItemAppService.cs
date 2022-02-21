using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace gfa_web.Sales
{
    public interface IRawSaleItemAppService :
        ICrudAppService< //Defines CRUD methods
            RawSaleItemDto, //Used to show books
            Guid, //Primary key of the book entity
            GetSaleItemInput, //Used for paging/sorting
            CreateUpdateRawSaleItemDto> //Used to create/update a book
    {
        void BatchInsert(List<CreateUpdateRawSaleItemDto> createUpdateRawSaleItemDtos);
    }
}