using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using gfa_web.Data;
using Volo.Abp.DependencyInjection;

namespace gfa_web.EntityFrameworkCore
{
    public class EntityFrameworkCoregfa_webDbSchemaMigrator
        : Igfa_webDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoregfa_webDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the gfa_webDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<gfa_webDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
