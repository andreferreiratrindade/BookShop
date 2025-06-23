
using Microsoft.EntityFrameworkCore;
using CatalogService.Infra;

namespace CatalogService.Api.Configuration
{
     public static class DataBaseManagement
    {
        public static void MigrationInitialization (this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var _db = scope.ServiceProvider.GetRequiredService<StockContext>();

                _db.Database.Migrate();
                _db.LoadStockList();
            }
        }
    }
}
