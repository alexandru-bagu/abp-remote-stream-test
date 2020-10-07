using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace RemoteStream.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(RemoteStreamHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class RemoteStreamConsoleApiClientModule : AbpModule
    {
        
    }
}
