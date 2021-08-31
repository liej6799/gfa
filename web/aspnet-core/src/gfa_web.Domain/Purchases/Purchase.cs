using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace gfa_web.Purchases
{
    public class Purchase : AuditedAggregateRoot<Guid>, ISoftDelete
    {
        public int SourceId { get; set; }
        
        public DateTime DatePurchase { get; set; }
        public Guid VendorId { get; set; }

        public Double TotalAmount { get; set; }
        
        public bool IsDeleted { get; set; }
    }
}