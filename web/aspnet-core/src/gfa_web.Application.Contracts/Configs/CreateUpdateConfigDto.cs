using System;
using Volo.Abp.Application.Dtos;

namespace gfa_web.Configs
{
    public class CreateUpdateConfigDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public bool IsDaily { get; set; }
        public bool IsMonthly { get; set; }
        public bool IsYearly { get; set; }
        public bool IsAll { get; set; }
    }
}