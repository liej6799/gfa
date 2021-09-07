using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace gfa_web.Purchases
{
    public class GetPurchaseInput : PagedAndSortedResultRequestDto
    {
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }

        public PurchaseGroup GroupBy { get; set; } = PurchaseGroup.None;
    }
}