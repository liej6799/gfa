using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace gfa_shared.Model
{
    public class Item : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public Double BuyPrice { get; set; }

        public Double SellPrice { get; set; }
    }
}