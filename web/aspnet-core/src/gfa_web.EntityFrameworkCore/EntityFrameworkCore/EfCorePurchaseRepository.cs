using System;
using System.Threading.Tasks;
using gfa_web.Purchases;
using gfa_web.Vendors;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace gfa_web.EntityFrameworkCore
{
    public class EfCorePurchaseRepository
        : EfCoreRepository<gfa_webDbContext, Purchase, Guid>,
            IPurchaseRepository
    {
        public EfCorePurchaseRepository(
            IDbContextProvider<gfa_webDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }
    
  
}