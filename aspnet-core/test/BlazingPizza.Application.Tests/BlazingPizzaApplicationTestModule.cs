using Volo.Abp.Modularity;

namespace BlazingPizza
{
    [DependsOn(
        typeof(BlazingPizzaApplicationModule),
        typeof(BlazingPizzaDomainTestModule)
        )]
    public class BlazingPizzaApplicationTestModule : AbpModule
    {

    }
}