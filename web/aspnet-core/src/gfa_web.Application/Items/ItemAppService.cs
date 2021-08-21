using System;
using System.Collections.Generic;
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
        public ItemAppService(IRepository<Item, Guid> repository)
            : base(repository)
        {

        }

        public List<ItemDto> GetCountryListWithoutPaged()
        {
            //var commonCountry = await Repository.GetListAsync();
            var item = new List<Item>();
            item.Add(new Item()
            {
                Name = "awd"
            });
            return ObjectMapper.Map<List<Item>, List<ItemDto>>(item);
        }
    }
}