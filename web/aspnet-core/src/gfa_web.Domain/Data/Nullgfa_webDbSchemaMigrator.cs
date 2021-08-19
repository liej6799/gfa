using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace gfa_web.Data
{
    /* This is used if database provider does't define
     * Igfa_webDbSchemaMigrator implementation.
     */
    public class Nullgfa_webDbSchemaMigrator : Igfa_webDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}