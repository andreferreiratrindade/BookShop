using Framework.Core.Data;
using CatalogService.Domain.Models.Entities;
using CatalogService.Domain.Models.Entities.Ids;

namespace CatalogService.Domain.Models.Repositories
{
    public interface ITransactionStockRepository : IRepository<TransactionStock>
    {
        void Update(TransactionStock activity);
        void Add(TransactionStock activity);
        void Delete(Guid activityId);
        Task<TransactionStock?>  GetById(TransactionStockId transactionStockId);
        Task<TransactionStock?> GetByIdAsync(Guid activityId);

        IQueryable<TransactionStock> GetQueryable();
    }
}
