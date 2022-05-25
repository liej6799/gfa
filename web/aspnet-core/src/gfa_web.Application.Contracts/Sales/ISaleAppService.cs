using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace gfa_web.Sales
{
    public interface ISaleAppService :
        ICrudAppService< //Defines CRUD methods
            SaleDto, //Used to show books
            Guid, //Primary key of the book entity
            GetSaleInput, //Used for paging/sorting
            CreateUpdateSaleDto> //Used to create/update a book
    {
        Task<List<SaleDto>> GetListNoPaged(GetSaleInputNoPaged input);
        
        void BatchInsert(List<CreateUpdateSaleDto> createUpdateSaleDtos);

        Task<List<CreateUpdateSaleDto>> GetListNoPagedDate(GetSaleDateInput input);
    }
    
}