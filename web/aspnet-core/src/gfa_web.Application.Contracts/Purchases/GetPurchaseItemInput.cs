using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace gfa_web.Purchases
{
    public class GetPurchaseItemInput : PagedAndSortedResultRequestDto
    {
        public Guid PurchaseId { get; set; }
        public string Filter { get; set; }
    }
    
    public class GetPurchaseItemInputHistory : PagedAndSortedResultRequestDto
    {
        public Guid ItemId { get; set; }
    }
    
    public class GetPurchaseItemDateInput : PagedAndSortedResultRequestDto
    {
        [Required]
        public DateTime StartDate { get; set; }

        [Required] public DateTime EndDate { get; set; }
    }
}