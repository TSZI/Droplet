using Droplet.Data;
using Microsoft.EntityFrameworkCore;

namespace Droplet.Helpers
{
    public static class DataHelper
    {
        public static async Task ManageDataAsync(IServiceProvider svcProvider)
        {
            // Get an instance of the db application context
            var dbContextsvc = svcProvider.GetRequiredService<ApplicationDbContext>();

            // Migration: this is equivalent to update-databae
            await dbContextsvc.Database.MigrateAsync();
        }
    }
}
