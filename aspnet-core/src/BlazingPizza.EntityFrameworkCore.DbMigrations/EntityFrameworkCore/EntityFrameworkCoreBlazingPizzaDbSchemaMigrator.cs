using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BlazingPizza.Data;
using Volo.Abp.DependencyInjection;

namespace BlazingPizza.EntityFrameworkCore
{
    public class EntityFrameworkCoreBlazingPizzaDbSchemaMigrator
        : IBlazingPizzaDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreBlazingPizzaDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the BlazingPizzaMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<BlazingPizzaMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}