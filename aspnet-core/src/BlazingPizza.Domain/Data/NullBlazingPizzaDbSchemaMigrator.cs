using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace BlazingPizza.Data
{
    /* This is used if database provider does't define
     * IBlazingPizzaDbSchemaMigrator implementation.
     */
    public class NullBlazingPizzaDbSchemaMigrator : IBlazingPizzaDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}