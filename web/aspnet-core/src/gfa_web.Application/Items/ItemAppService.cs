using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace gfa_web.Items
{
    public class ItemAppService :
        CrudAppService<
            Item, //The Book entity
            ItemDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateItemDto>, //Used to create/update a book
        IItemAppService //implement the IBookAppService
    {
        private IRepository<Item> itemsRepository;
        public ItemAppService(IRepository<Item, Guid> repository)
            : base(repository)
        {

        }
        
        public List<CreateUpdateItemDto> GetListNoPaged()
        {
            return ObjectMapper.Map<List<Item>, List<CreateUpdateItemDto>>(Repository.ToList());
        }
        
        public void BatchUpdate(List<CreateUpdateItemDto> createUpdateItemDto)
        {
            Repository.UpdateManyAsync(ObjectMapper.Map<List<CreateUpdateItemDto>, List<Item>>(createUpdateItemDto));
        }
        
        public void BatchInsert(List<CreateUpdateItemDto> createUpdateItemDto)
        {
            Repository.InsertManyAsync(ObjectMapper.Map<List<CreateUpdateItemDto>, List<Item>>(createUpdateItemDto));
        }
    
    }
}