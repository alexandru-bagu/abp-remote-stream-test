using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace RemoteStream.Data
{
    /* This is used if database provider does't define
     * IRemoteStreamDbSchemaMigrator implementation.
     */
    public class NullRemoteStreamDbSchemaMigrator : IRemoteStreamDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}