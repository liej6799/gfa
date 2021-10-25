using System;
using gfa_web.Purchases;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace gfa_web.EntityFrameworkCore
{
    public class EfCorePurchaseItemRepository
        : EfCoreRepository<gfa_webDbContext, PurchaseItem, Guid>,
            IPurchaseItemRepository
    {
        public EfCorePurchaseItemRepository(
            IDbContextProvider<gfa_webDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }
}