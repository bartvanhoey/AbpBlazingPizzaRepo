using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace BlazingPizza.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(BlazingPizzaHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class BlazingPizzaConsoleApiClientModule : AbpModule
    {
        
    }
}
