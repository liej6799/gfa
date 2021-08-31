using System;
using Volo.Abp.Application.Dtos;

namespace gfa_web.Purchases
{
    public class PurchaseItemDto : AuditedEntityDto<Guid>
    {
        public int SourceId { get; set; }

        public Double Quantity { get; set; }
        
        public Double Price { get; set; }
        
        public Double Total { get; set; }
        
        public Guid ItemId { get; set; }
        
        public Guid PurchaseId { get; set; }
    }
}