using System.Threading.Tasks;

namespace gfa_web.Data
{
    public interface Igfa_webDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
