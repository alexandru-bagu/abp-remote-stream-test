using System;
using System.IO;
using System.Threading.Tasks;
using RemoteStream.Test;
using Volo.Abp.Content;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Identity;

namespace RemoteStream.HttpApi.Client.ConsoleTestApp
{
    public class ClientDemoService : ITransientDependency
    {
        private readonly IProfileAppService _profileAppService;
        private readonly ITestAppService _testAppService;

        public ClientDemoService(IProfileAppService profileAppService, ITestAppService testAppService)
        {
            _profileAppService = profileAppService;
            _testAppService = testAppService;
        }

        public async Task RunAsync()
        {
            var output = await _profileAppService.GetAsync();
            Console.WriteLine($"UserName : {output.UserName}");
            Console.WriteLine($"Email    : {output.Email}");
            Console.WriteLine($"Name     : {output.Name}");
            Console.WriteLine($"Surname  : {output.Surname}");

            var id = Guid.NewGuid();
            var remoteContent = new RemoteStreamContent(new MemoryStream(new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })) { ContentType = "application/octet-stream" };
            await _testAppService.Upload(remoteContent, id);
            var dl = await _testAppService.Download(id);
            var ms = new MemoryStream();
            await dl.GetStream().CopyToAsync(ms);
        }
    }
}