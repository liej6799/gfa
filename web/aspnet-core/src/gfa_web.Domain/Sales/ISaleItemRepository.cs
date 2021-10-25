using System;
using Volo.Abp.Domain.Repositories;

namespace gfa_web.Sales
{
    public interface ISaleItemRepository : IRepository<SaleItem, Guid>
    {

    }
}