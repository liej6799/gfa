using System;
using Volo.Abp.Application.Dtos;

namespace gfa_web.Vendors
{
    public class CreateUpdateVendorDto : AuditedEntityDto<Guid>
    {        
        public int SourceId { get; set; }
        public string Name { get; set; }
    }
}