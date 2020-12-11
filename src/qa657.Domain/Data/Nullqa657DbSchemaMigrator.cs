using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace qa657.Data
{
    /* This is used if database provider does't define
     * Iqa657DbSchemaMigrator implementation.
     */
    public class Nullqa657DbSchemaMigrator : Iqa657DbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}