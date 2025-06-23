using Framework.Core.Data;
using CatalogService.Domain.Models.Entities;
using CatalogService.Domain.Models.Entities.Ids;

namespace CatalogService.Domain.Models.Repositories
{
    public interface IStockRepository : IRepository<Stock>
    {

        Task<Stock> GetById(StockId StockId);

        Task<Stock> GetBySymbol(string symbol);
    }
}
