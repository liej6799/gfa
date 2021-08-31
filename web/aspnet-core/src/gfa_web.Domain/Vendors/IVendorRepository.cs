using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace gfa_web.Vendors
{
    public interface IVendorRepository : IRepository<Vendor, Guid>
    {
        Task<Vendor> FindByNameAsync(string name);
    }
}