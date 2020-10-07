using System.Threading.Tasks;

namespace RemoteStream.Data
{
    public interface IRemoteStreamDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
