using System.Threading.Tasks;

namespace qa657.Data
{
    public interface Iqa657DbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
