using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using gfa_web.Vendors;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace gfa_web.EntityFrameworkCore
{
    public class EfCoreVendorRepository
        : EfCoreRepository<gfa_webDbContext, Vendor, Guid>,
            IVendorRepository
    {
        public EfCoreVendorRepository(
            IDbContextProvider<gfa_webDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public async Task<Vendor> FindByNameAsync(string name)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.FirstOrDefaultAsync(author => author.Name == name);
        }
    }
}