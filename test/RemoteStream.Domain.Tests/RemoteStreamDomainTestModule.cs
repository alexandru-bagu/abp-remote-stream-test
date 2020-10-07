using RemoteStream.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace RemoteStream
{
    [DependsOn(
        typeof(RemoteStreamEntityFrameworkCoreTestModule)
        )]
    public class RemoteStreamDomainTestModule : AbpModule
    {

    }
}