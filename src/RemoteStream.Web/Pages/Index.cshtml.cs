using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RemoteStream.Test;
using Volo.Abp.Content;

namespace RemoteStream.Web.Pages
{
    public class IndexModel : RemoteStreamPageModel
    {
        private readonly ITestAppService _testAppService;

        [BindProperty]
        public Guid? Id { get; set; }

        [BindProperty]
        public IFormFile Upload { get; set; }

        public IndexModel(ITestAppService testAppService)
        {
            _testAppService = testAppService;
        }

        public void OnGet()
        {
            Id = Guid.NewGuid();
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }

        public async Task OnPostAsync()
        {
            if (Id != null)
            {
                await _testAppService.Upload(new RemoteStreamContent(Upload.OpenReadStream()) { ContentType = Upload.ContentType }, Id.Value);
                var stream = await _testAppService.Download(Id.Value);
                var ms = new MemoryStream();
                await stream.GetStream().CopyToAsync(ms);
            }
        }
    }
}