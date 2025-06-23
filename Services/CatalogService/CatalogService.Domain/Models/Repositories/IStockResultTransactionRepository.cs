using Framework.Core.Data;
using CatalogService.Domain.Models.Entities;
using CatalogService.Domain.Models.Entities.Ids;

namespace CatalogService.Domain.Models.Repositories
{
    public interface IStockResultTransactionStockRepository : IRepository<StockResultTransaction>
    {
        void Update(StockResultTransaction stockResultTransaction);
        void Add(StockResultTransaction stockResultTransaction);
        void Delete(Guid stockId);
        Task<StockResultTransaction>  GetByStockId(StockId stockId);


    }
}
