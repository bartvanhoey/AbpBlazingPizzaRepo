using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace BlazingPizza.EntityFrameworkCore
{
    public static class BlazingPizzaDbContextModelCreatingExtensions
    {
        public static void ConfigureBlazingPizza(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(BlazingPizzaConsts.DbTablePrefix + "YourEntities", BlazingPizzaConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}