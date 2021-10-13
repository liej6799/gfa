using System;
using Volo.Abp.Application.Dtos;

namespace gfa_web.Sales
{
    public class SaleItemDto : AuditedEntityDto<Guid>
    {
        public int SourceId { get; set; }

        public Double Quantity { get; set; }
        
        public Double Price { get; set; }
        
        public Double Total { get; set; }
        
        public Guid ItemId { get; set; }

        public Guid SaleId { get; set; }
        
        public String ItemName { get; set; }
        public Double CurrentBuyPrice { get; set; }
        
        public DateTime DateSales { get; set; }
        
    }

}