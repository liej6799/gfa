using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace gfa_web.Items
{
    public class CreateUpdateItemDto : AuditedEntityDto<Guid>
    {
        [Required]
        public int SourceId { get; set; }
        
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [StringLength(128)]
        public string Code { get; set; }
        
        public Double BuyPrice { get; set; }
        
        public Double SellPrice { get; set; }
        
        public Double ProfitLoss { get; set; }

        public Double Quantity { get; set; }
    }
}