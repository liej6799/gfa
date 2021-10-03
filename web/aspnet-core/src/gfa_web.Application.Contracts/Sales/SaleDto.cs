using System;
using Volo.Abp.Application.Dtos;

namespace gfa_web.Sales
{
    public class SaleDto : AuditedEntityDto<Guid>
    {
        public int SourceId { get; set; }

        public DateTime DateSales { get; set; }

        public Double TotalAmount { get; set; }

        public Double TotalCash { get; set; }

        public Double TotalChange { get; set; }

    }


}