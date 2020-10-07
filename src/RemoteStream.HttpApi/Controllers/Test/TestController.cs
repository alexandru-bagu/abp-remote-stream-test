using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RemoteStream.Test;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Content;

namespace RemoteStream.Controllers
{
    [RemoteService]
    [Area("app")]
    [ControllerName("Test")]
    [Route("api/app/test")]
    public class TestController : AbpController, ITestAppService
    {
        private readonly ITestAppService _testAppService;

        public TestController(ITestAppService testAppService)
        {
            _testAppService = testAppService;
        }

        [HttpPost]
        [Route("upload/{id}/{overwrite}")]
        [Route("upload/{id}")]
        [DisableRequestSizeLimit]
        public virtual async Task Upload([FromBody] IRemoteStreamContent remoteStreamContent, Guid id, bool overwrite = false)
        {
            await _testAppService.Upload(remoteStreamContent, id, overwrite);
        }

        [HttpGet]
        [Route("download/{id}")]
        public virtual async Task<IRemoteStreamContent> Download(Guid id)
        {
            return await _testAppService.Download(id);
        }
    }
}