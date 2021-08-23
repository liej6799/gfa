using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading;
using System.Threading.Tasks;
using gfa_web.Items;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace gfa_web.EntityFrameworkCore
{
    public class EfCoreItemRepository : EfCoreRepository<gfa_webDbContext, Item, Guid>, IItemRepository
    {
        public EfCoreItemRepository(IDbContextProvider<gfa_webDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
        
        public virtual async Task<List<Item>> GetListAsync(
            string sorting = null,
            int maxResultCount = int.MaxValue,
            int skipCount = 0,
            string filter = null,
            CancellationToken cancellationToken = default)
        {
            return await (await GetDbSetAsync())
                .WhereIf(
                    !filter.IsNullOrWhiteSpace(),
                    u =>
                        (u.Name.Contains(filter) || (u.Code.Contains(filter)))
                )
                .OrderBy(sorting.IsNullOrEmpty() ? nameof(Item.Name) : sorting)
                .PageBy(skipCount, maxResultCount)
                .ToListAsync(GetCancellationToken(cancellationToken));
        }
        
        public virtual async Task<long> GetCountAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            return await this
                .WhereIf(
                    !filter.IsNullOrWhiteSpace(),
                    u =>
                        (u.Name.Contains(filter) || (u.Code.Contains(filter)))
                ).CountAsync(cancellationToken: cancellationToken);
        }
    }
}