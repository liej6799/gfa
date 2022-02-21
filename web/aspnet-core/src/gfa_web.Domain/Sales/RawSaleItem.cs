using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace gfa_web.Sales
{
    public class RawSaleItem : AuditedAggregateRoot<Guid>, ISoftDelete
    {
        public int SourceId { get; set; }

        public Double Quantity { get; set; }

        public Double Total { get; set; }
        
        public int SourceItemId { get; set; }

        public int SourceSaleId { get; set; }
        
        public bool IsDeleted { get; set; }
    }
}