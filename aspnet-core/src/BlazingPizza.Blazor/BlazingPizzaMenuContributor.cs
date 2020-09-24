using System.Threading.Tasks;
using BlazingPizza.Localization;
using Volo.Abp.UI.Navigation;

namespace BlazingPizza.Blazor
{
    public class BlazingPizzaMenuContributor : IMenuContributor
    {
        public Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if(context.Menu.DisplayName != StandardMenus.Main)
            {
                return Task.CompletedTask;
            }

            var l = context.GetLocalizer<BlazingPizzaResource>();

            context.Menu.Items.Insert(
                0,
                new ApplicationMenuItem(
                    "BlazingPizza.Home",
                    l["Menu:Home"],
                    "/",
                    icon: "fas fa-home"
                )
            );

            return Task.CompletedTask;
        }
    }
}
