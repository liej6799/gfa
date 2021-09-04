using System;
using Volo.Abp.Application.Dtos;

namespace gfa_web.Purchases
{
    public class GetPurchaseItemInput : PagedAndSortedResultRequestDto
    {
        public Guid PurchaseId { get; set; }
    }
    
    public class GetItemPurchaseHistoryInput : PagedAndSortedResultRequestDto
    {
        public Guid ItemId { get; set; }
    }
    
}