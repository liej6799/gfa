using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace gfa_web.Purchases
{
    public class CreateUpdatePurchaseDto : AuditedEntityDto<Guid>
    {
        public int SourceId { get; set; }
        
        public DateTime DatePurchase { get; set; }
        
        public Guid VendorId { get; set; }

        public int VendorSourceId { get; set; }
        
        public Double TotalAmount { get; set; }
        
    }
}