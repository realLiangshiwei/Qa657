using Volo.Abp.Settings;

namespace qa657.Settings
{
    public class qa657SettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(qa657Settings.MySetting1));
        }
    }
}
