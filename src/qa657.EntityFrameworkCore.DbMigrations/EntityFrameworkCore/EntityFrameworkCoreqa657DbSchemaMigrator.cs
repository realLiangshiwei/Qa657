using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using qa657.Data;
using Volo.Abp.DependencyInjection;

namespace qa657.EntityFrameworkCore
{
    public class EntityFrameworkCoreqa657DbSchemaMigrator
        : Iqa657DbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreqa657DbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the qa657MigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<qa657MigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}