using Volo.Abp.Settings;

namespace RemoteStream.Settings
{
    public class RemoteStreamSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(RemoteStreamSettings.MySetting1));
        }
    }
}
