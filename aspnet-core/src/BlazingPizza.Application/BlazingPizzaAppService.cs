using System;
using System.Collections.Generic;
using System.Text;
using BlazingPizza.Localization;
using Volo.Abp.Application.Services;

namespace BlazingPizza
{
    /* Inherit your application services from this class.
     */
    public abstract class BlazingPizzaAppService : ApplicationService
    {
        protected BlazingPizzaAppService()
        {
            LocalizationResource = typeof(BlazingPizzaResource);
        }
    }
}
