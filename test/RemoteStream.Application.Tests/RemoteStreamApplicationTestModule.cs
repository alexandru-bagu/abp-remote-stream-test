using Volo.Abp.Modularity;

namespace RemoteStream
{
    [DependsOn(
        typeof(RemoteStreamApplicationModule),
        typeof(RemoteStreamDomainTestModule)
        )]
    public class RemoteStreamApplicationTestModule : AbpModule
    {

    }
}