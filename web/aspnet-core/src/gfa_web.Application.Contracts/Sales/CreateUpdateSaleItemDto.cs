using System;
using Volo.Abp.Application.Dtos;

namespace gfa_web.Sales
{
    public class CreateUpdateSaleItemDto : AuditedEntityDto<Guid>
    {
        public int SourceId { get; set; }

        public Double Quantity { get; set; }
        
        public Double Price { get; set; }
        
        public Double Total { get; set; }
        
        public Guid ItemId { get; set; }

        public Guid SaleId { get; set; }
        
        public int ItemSourceId { get; set; }
        
        public int SaleSourceId { get; set; }
    }
}