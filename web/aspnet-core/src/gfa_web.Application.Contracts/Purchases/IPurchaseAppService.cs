using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace gfa_web.Purchases
{
    public interface IPurchaseAppService :
        ICrudAppService< //Defines CRUD methods
            PurchaseDto, //Used to show books
            Guid, //Primary key of the book entity
            GetPurchaseInput, //Used for paging/sorting
            CreateUpdatePurchaseDto> //Used to create/update a book
    {
        Task<List<CreateUpdatePurchaseDto>> GetListNoPaged();
        
        void BatchInsert(List<CreateUpdatePurchaseDto> createUpdatePurchaseDtos);
    }
}