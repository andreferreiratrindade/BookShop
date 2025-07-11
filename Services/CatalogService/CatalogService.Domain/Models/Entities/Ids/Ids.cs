namespace CatalogService.Domain.Models.Entities.Ids;

public readonly record struct StockId (Guid Value);
public readonly record struct PriceStockId(Guid Value);
public readonly record struct TransactionStockId(Guid Value);
public readonly record struct StockResultTransactionId(Guid Value);
