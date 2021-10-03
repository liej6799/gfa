using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace gfa_web.Sales
{
    public interface ISaleItemAppService :
        ICrudAppService< //Defines CRUD methods
            SaleItemDto, //Used to show books
            Guid, //Primary key of the book entity
            GetSaleItemInput, //Used for paging/sorting
            CreateUpdateSaleItemDto> //Used to create/update a book
    {
        Task<List<CreateUpdateSaleItemDto>> GetListNoPaged();
        
        void BatchInsert(List<CreateUpdateSaleItemDto> createUpdateSaleItemDtos);
    }
}