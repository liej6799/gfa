using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace gfa_web.Purchases
{
    public class PurchaseItem : AuditedAggregateRoot<Guid>, ISoftDelete
    {
        public int SourceId { get; set; }

        public Double Quantity { get; set; }
        
        public Double Price { get; set; }
        
        public Double Total { get; set; }
        
        public Guid ItemId { get; set; }
        
        public Guid PurchaseId { get; set; }
        
        public bool IsDeleted { get; set; }
    }
}