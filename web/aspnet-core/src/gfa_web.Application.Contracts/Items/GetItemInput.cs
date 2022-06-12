using System;
using Volo.Abp.Application.Dtos;

namespace gfa_web.Items
{
    public class GetItemInput : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }

    public class GetItemInputFilter
    {
        public string Filter { get; set; }
    }

    public class GetQuantityTrackerInput : PagedAndSortedResultRequestDto
    {
        public Guid ItemId { get; set; }
    }
}