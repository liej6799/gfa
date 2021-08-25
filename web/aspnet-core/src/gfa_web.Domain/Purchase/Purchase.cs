using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace gfa_web.Purchase
{
    public class Purchase : AuditedAggregateRoot<Guid>, ISoftDelete
    {
        public DateTime DatePurchase { get; set; }
        
        public DateTime VendorName { get; set; }
        
        public bool IsDeleted { get; set; }
    }
}