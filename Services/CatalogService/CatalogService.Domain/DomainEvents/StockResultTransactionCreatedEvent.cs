
using Framework.Core.DomainObjects;
using Framework.Shared.IntegrationEvent.Enums;
using CatalogService.Domain.Models.Entities.Ids;

namespace CatalogService.Domain.DomainEvents
{
    public class StockResultTransactionCreatedEvent : DomainEvent
    {

        public StockId StockId {get;set;}
        public StockResultTransactionId StockResultTransactionId {get;set;}

        public StockResultTransactionCreatedEvent( StockResultTransactionId stockResultTransactionId,
                                         StockId stockId,
                                         CorrelationId CorrelationId) :base(CorrelationId)
        {
            this.StockResultTransactionId = stockResultTransactionId;

            this.StockId = stockId;
        }
    }
}
