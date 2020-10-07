using RemoteStream.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace RemoteStream.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class RemoteStreamController : AbpController
    {
        protected RemoteStreamController()
        {
            LocalizationResource = typeof(RemoteStreamResource);
        }
    }
}