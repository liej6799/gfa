using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace gfa_web.Sales
{
    public class GetSaleItemInput : PagedAndSortedResultRequestDto
    {
        public Guid SaleId { get; set; }
        public string Filter { get; set; }
    }
    
    public class GetSalesItemHistoryInput : PagedAndSortedResultRequestDto
    {
        public Guid ItemId { get; set; }
    }
}