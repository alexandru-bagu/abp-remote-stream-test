using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace RemoteStream.Web
{
    [Dependency(ReplaceServices = true)]
    public class RemoteStreamBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "RemoteStream";
    }
}
