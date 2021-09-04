using System;
using Volo.Abp.Application.Dtos;

namespace gfa_web.Purchases
{
    public class PurchaseDto : AuditedEntityDto<Guid>
    {        
        public int SourceId { get; set; }
        
        public DateTime DatePurchase { get; set; }
        
        public Guid VendorId { get; set; }
        
        public String VendorName { get; set; }

        public Double TotalAmount { get; set; }
    }
}