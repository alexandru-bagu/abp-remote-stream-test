using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace RemoteStream.EntityFrameworkCore
{
    public static class RemoteStreamDbContextModelCreatingExtensions
    {
        public static void ConfigureRemoteStream(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(RemoteStreamConsts.DbTablePrefix + "YourEntities", RemoteStreamConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}