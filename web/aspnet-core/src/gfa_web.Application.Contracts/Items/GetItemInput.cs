using Volo.Abp.Application.Dtos;

namespace gfa_web.Items
{
    public class GetItemInput : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}