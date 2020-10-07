using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RemoteStream.Data;
using Volo.Abp.DependencyInjection;

namespace RemoteStream.EntityFrameworkCore
{
    public class EntityFrameworkCoreRemoteStreamDbSchemaMigrator
        : IRemoteStreamDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreRemoteStreamDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the RemoteStreamMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<RemoteStreamMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}