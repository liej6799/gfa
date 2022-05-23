using System;
using System.ComponentModel.DataAnnotations;
using gfa_web.Purchases;
using Volo.Abp.Application.Dtos;

namespace gfa_web.Sales
{
    public class GetSaleInput : PagedAndSortedResultRequestDto
    {
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        
        
    }

    public class GetSaleInputNoPaged
    {
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public string Sorting { get; set; }
    }

}