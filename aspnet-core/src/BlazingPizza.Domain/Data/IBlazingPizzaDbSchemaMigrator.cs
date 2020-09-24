using System.Threading.Tasks;

namespace BlazingPizza.Data
{
    public interface IBlazingPizzaDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
