using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace gfa_web.Sales
{
    public class Sale : AuditedAggregateRoot<Guid>, ISoftDelete
    {
        public int SourceId { get; set; }

        public DateTime DateSales { get; set; }

        public Double TotalAmount { get; set; }

        public Double TotalCash { get; set; }

        public Double TotalChange { get; set; }

        public bool IsDeleted { get; set; }
    }
}