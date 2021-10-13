using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace gfa_web.Purchases
{
    public interface IPurchaseItemAppService :
        ICrudAppService< //Defines CRUD methods
            PurchaseItemDto, //Used to show books
            Guid, //Primary key of the book entity
            GetPurchaseItemInput, //Used for paging/sorting
            CreateUpdatePurchaseItemDto> //Used to create/update a book
    {
        Task<List<CreateUpdatePurchaseItemDto>> GetListNoPaged();
        void BatchInsert(List<CreateUpdatePurchaseItemDto> createUpdatePurchaseItemDtos);
    }
}