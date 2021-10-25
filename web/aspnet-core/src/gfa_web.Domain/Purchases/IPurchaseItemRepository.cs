using System;
using Volo.Abp.Domain.Repositories;

namespace gfa_web.Purchases
{
    public interface IPurchaseItemRepository : IRepository<PurchaseItem, Guid>
    {

    }
}