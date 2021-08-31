using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace gfa_web.Purchases
{
    public interface IPurchaseRepository : IRepository<Purchase, Guid>
    {

    }

}