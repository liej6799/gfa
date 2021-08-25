using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using gfa_web.Items;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace gfa_web.Configs
{
    public interface IConfigAppService :
        ICrudAppService< //Defines CRUD methods
            ConfigDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto,
            CreateUpdateConfigDto> //Used to create/update a book
    {
        
    }
}