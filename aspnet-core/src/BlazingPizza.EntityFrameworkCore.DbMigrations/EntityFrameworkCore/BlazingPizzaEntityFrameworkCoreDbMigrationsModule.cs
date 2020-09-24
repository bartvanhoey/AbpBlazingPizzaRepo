using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace BlazingPizza.EntityFrameworkCore
{
    [DependsOn(
        typeof(BlazingPizzaEntityFrameworkCoreModule)
        )]
    public class BlazingPizzaEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<BlazingPizzaMigrationsDbContext>();
        }
    }
}
