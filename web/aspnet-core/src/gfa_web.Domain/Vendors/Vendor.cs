using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace gfa_web.Vendors
{
    public class Vendor : AuditedAggregateRoot<Guid>, ISoftDelete
    {
        public int SourceId { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}