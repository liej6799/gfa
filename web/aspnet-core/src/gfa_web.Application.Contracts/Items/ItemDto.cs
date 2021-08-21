using System;
using Volo.Abp.Application.Dtos;

namespace gfa_web.Items
{
    public class ItemDto : AuditedEntityDto<Guid>
    {        
        public int SourceId { get; set; }
        
        public string Name { get; set; }

        public string Code { get; set; }

        public Double BuyPrice { get; set; }

        public Double SellPrice { get; set; }
        public bool IsUpdated { get; set; }
    }
}