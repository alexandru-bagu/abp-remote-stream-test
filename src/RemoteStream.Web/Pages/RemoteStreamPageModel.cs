using RemoteStream.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace RemoteStream.Web.Pages
{
    public abstract class RemoteStreamPageModel : AbpPageModel
    {
        protected RemoteStreamPageModel()
        {
            LocalizationResourceType = typeof(RemoteStreamResource);
        }
    }
}