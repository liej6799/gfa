using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.TenantManagement;

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
        protected IItemRepository ItemRepository { get; }
        public ItemAppService(IRepository<Item, Guid> repository,
            IItemRepository itemRepository)
            : base(repository)
        {
            ItemRepository = itemRepository;
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
        
        public async Task<PagedResultDto<ItemDto>> GetListFilterAsync(GetItemInput input)
        {
            if (input.Sorting.IsNullOrWhiteSpace())
            {
                input.Sorting = nameof(Tenant.Name);
            }

            var count = await ItemRepository.GetCountAsync(input.Filter);
            var list = await ItemRepository.GetListAsync(
                input.Sorting,
                input.MaxResultCount,
                input.SkipCount,
                input.Filter
            );

            return new PagedResultDto<ItemDto>(
                count,
                ObjectMapper.Map<List<Item>, List<ItemDto>>(list)
            );
        }
    
    }
}