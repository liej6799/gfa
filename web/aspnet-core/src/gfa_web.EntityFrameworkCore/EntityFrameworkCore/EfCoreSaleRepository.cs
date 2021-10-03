using System;
using gfa_web.Purchases;
using gfa_web.Sales;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace gfa_web.EntityFrameworkCore
{
    public class EfCoreSaleRepository
        : EfCoreRepository<gfa_webDbContext, Sale, Guid>,
            ISaleRepository
    {
        public EfCoreSaleRepository(
            IDbContextProvider<gfa_webDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }
}