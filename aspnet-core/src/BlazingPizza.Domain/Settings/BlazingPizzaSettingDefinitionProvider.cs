using Volo.Abp.Settings;

namespace BlazingPizza.Settings
{
    public class BlazingPizzaSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(BlazingPizzaSettings.MySetting1));
        }
    }
}
