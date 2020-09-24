using BlazingPizza.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace BlazingPizza.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(BlazingPizzaEntityFrameworkCoreDbMigrationsModule),
        typeof(BlazingPizzaApplicationContractsModule)
        )]
    public class BlazingPizzaDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
