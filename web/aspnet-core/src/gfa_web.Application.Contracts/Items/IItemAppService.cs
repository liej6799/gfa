using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace gfa_web.Items
{
    public interface IItemAppService :
        ICrudAppService< //Defines CRUD methods
            ItemDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateItemDto> //Used to create/update a book
    {
        List<CreateUpdateItemDto> GetListNoPaged();
        void BatchInsert(List<CreateUpdateItemDto> createUpdateItemDto);
        Task<PagedResultDto<ItemDto>> GetListFilterAsync(GetItemInput input);
    }
}