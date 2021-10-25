using System;
using gfa_web.Sales;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace gfa_web.EntityFrameworkCore
{
    public class EfCoreSaleItemRepository
        : EfCoreRepository<gfa_webDbContext, SaleItem, Guid>,
            ISaleItemRepository
    {
        public EfCoreSaleItemRepository(
            IDbContextProvider<gfa_webDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }
}