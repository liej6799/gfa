using System;
using Volo.Abp.Application.Dtos;

namespace gfa_web.Sales
{
    public class RawSaleItemDto : AuditedEntityDto<Guid>
    {
        public int SourceId { get; set; }

        public Double Quantity { get; set; }

        public Double Total { get; set; }
        
        public int SourceItemId { get; set; }

        public int SourceSaleId { get; set; }
    }
}