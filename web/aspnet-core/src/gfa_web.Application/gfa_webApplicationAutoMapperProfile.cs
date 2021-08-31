using System.Collections.Generic;
using AutoMapper;
using gfa_web.Configs;
using gfa_web.Items;
using gfa_web.Purchases;
using gfa_web.Vendors;

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
            
            CreateMap<Config, ConfigDto>();
            
            CreateMap<Vendor, VendorDto>();
            CreateMap<Vendor, CreateUpdateVendorDto>();
            CreateMap<CreateUpdateVendorDto, Vendor>();
            
            CreateMap<Purchase, PurchaseDto>();
            CreateMap<Purchase, CreateUpdatePurchaseDto>();
            CreateMap<CreateUpdatePurchaseDto, Purchase>();
            
            
            CreateMap<PurchaseItem, PurchaseItemDto>();
            CreateMap<PurchaseItem, CreateUpdatePurchaseItemDto>();
            CreateMap<CreateUpdatePurchaseItemDto, PurchaseItem>();
            
        }
    }
}
