using BlazingPizza.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace BlazingPizza
{
    [DependsOn(
        typeof(BlazingPizzaEntityFrameworkCoreTestModule)
        )]
    public class BlazingPizzaDomainTestModule : AbpModule
    {

    }
}