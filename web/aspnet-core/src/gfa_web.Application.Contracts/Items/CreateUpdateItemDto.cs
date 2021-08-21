using System;
using System.ComponentModel.DataAnnotations;

namespace gfa_web.Items
{
    public class CreateUpdateItemDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [StringLength(128)]
        public string Code { get; set; }
        
        public Double BuyPrice { get; set; }
        
        public Double SellPrice { get; set; }
    }
}