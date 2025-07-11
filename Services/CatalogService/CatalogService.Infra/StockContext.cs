using System.Data;
using Framework.Core.Data;
using Framework.Core.Mediator;
using Microsoft.EntityFrameworkCore;
using CatalogService.Domain.Models.Entities;

namespace CatalogService.Infra
{
    public class StockContext : DbContextCustom<StockContext>
    {

        public StockContext(DbContextOptions<StockContext> options, IEventStored eventStored, IMediatorHandler mediatorHandler)
           : base(options,  eventStored,mediatorHandler)
        {
        }


        public DbSet<TransactionStock> TransactionsStock { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<StockResultTransaction>  StockResultTransactions{ get; set; }


public  void LoadStockList()
    {
        var stocks = new List<Stock>
        {
            Stock.Create("ITAU", "ITSA4"),
            Stock.Create("Ambev", "ABEV3"),
            Stock.Create("Usiminas", "USIM4")
        };

        var newStocks = stocks.Where(x=> !Stocks.Select(y=>y.Symbol).ToList().Any(y=> y == x.Symbol)).ToList();

        Stocks.AddRange(newStocks);
        this.SaveChanges();
    }
    }

}
