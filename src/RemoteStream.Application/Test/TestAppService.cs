using System;
using System.IO;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Content;

namespace RemoteStream.Test
{
    [RemoteService(IsEnabled = false)]
    public class TestAppService : ApplicationService, ITestAppService
    {
        public Task<IRemoteStreamContent> Download(Guid id)
        {
            /*not using the "using" keyword because we have to allow 
             * the underlying system to use and close the stream 
             * when it finishes using it*/
            var fs = new FileStream(id + ".blob", FileMode.OpenOrCreate);
            return Task.FromResult((IRemoteStreamContent)new RemoteStreamContent(fs) { ContentType = "application/octet-stream" });
        }

        public async Task Upload(IRemoteStreamContent remoteStreamContent, Guid id, bool overwrite = false)
        {
            var ms = new MemoryStream();
            using (var fs = new FileStream(id + ".blob", FileMode.Create))
                await remoteStreamContent.GetStream().CopyToAsync(fs);
        }
    }
}
