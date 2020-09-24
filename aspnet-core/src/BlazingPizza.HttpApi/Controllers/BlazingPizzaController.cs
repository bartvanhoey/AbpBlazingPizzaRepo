using BlazingPizza.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BlazingPizza.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class BlazingPizzaController : AbpController
    {
        protected BlazingPizzaController()
        {
            LocalizationResource = typeof(BlazingPizzaResource);
        }
    }
}