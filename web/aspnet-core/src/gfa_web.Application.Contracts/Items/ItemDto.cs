using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Identity;

namespace gfa_web.Items
{
    public class ItemDto : AuditedEntityDto<Guid>
    {        
        public int SourceId { get; set; }
        
        public string Name { get; set; }

        public string Code { get; set; }

        public Double BuyPrice { get; set; }

        public Double SellPrice { get; set; }
        
        public Double ProfitLoss { get; set; }
        
        public Double Quantity { get; set; }
        public DateTime Date { get; set; }
        
        public Double Remaining { get; set; }
    }
}