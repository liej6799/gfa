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
    
    public class GetItemHistoryInput : PagedAndSortedResultRequestDto
    {
        public Guid ItemId { get; set; }
    }
    
    public class GetSaleItemInputFilter
    {
        [Required]
        public Guid SaleId { get; set; }

        [Required]
        public string Sorting { get; set; }
    }

    public class GetSaleItemDateInput
    {
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
    }
}