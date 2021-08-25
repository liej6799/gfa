using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace gfa_web.Configs
{
    public class Config : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public bool IsDaily { get; set; }
        public bool IsMonthly { get; set; }
        public bool IsYearly { get; set; }
        public bool IsAll { get; set; }

        public Config(Guid id, string name, bool isDaily, bool isMonthly, bool isYearly, bool isAll) : base(id)
        {
            Name = name;
            IsDaily = isDaily;
            IsMonthly = isMonthly;
            IsYearly = isYearly;
            IsAll = isAll;
        }
    }

}