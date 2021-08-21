using System.Collections.Generic;
using AutoMapper;
using gfa_web.Items;

namespace gfa_web
{
    public class gfa_webApplicationAutoMapperProfile : Profile
    {
        public gfa_webApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Item, ItemDto>();
            CreateMap<Item, CreateUpdateItemDto>();
            CreateMap<CreateUpdateItemDto, Item>();
            
        }
    }
}
