using System;
using System.Collections.Generic;
using Volo.Abp.Application.Services;

namespace gfa_web.Sales
{
    public interface IRawSaleAppService :
        ICrudAppService< //Defines CRUD methods
            RawSaleDto, //Used to show books
            Guid, //Primary key of the book entity
            GetSaleInput, //Used for paging/sorting
            CreateUpdateRawSaleDto> //Used to create/update a book
    {

        void BatchInsert(List<CreateUpdateRawSaleDto> createUpdateRawSaleDtos);
    }
}