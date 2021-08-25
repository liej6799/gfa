using System;

using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace gfa_web.Configs
{
    public class ConfigAppService :
        CrudAppService<
            Config, //The Book entity
            ConfigDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateConfigDto>, //Used to create/update a book
        IConfigAppService //implement the IBookAppService
    {
        public ConfigAppService(IRepository<Config, Guid> repository) : base(repository)
        {
        }
    }
}