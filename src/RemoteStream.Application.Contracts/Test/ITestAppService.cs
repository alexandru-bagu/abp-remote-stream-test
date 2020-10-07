using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Content;

namespace RemoteStream.Test
{
    public interface ITestAppService : IApplicationService
    {
        Task Upload(IRemoteStreamContent remoteStreamContent, Guid id, bool overwrite = false);
        Task<IRemoteStreamContent> Download(Guid id);
    }
}
