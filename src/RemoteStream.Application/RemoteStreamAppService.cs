using System;
using System.Collections.Generic;
using System.Text;
using RemoteStream.Localization;
using Volo.Abp.Application.Services;

namespace RemoteStream
{
    /* Inherit your application services from this class.
     */
    public abstract class RemoteStreamAppService : ApplicationService
    {
        protected RemoteStreamAppService()
        {
            LocalizationResource = typeof(RemoteStreamResource);
        }
    }
}
