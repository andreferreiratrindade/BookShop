using System.ComponentModel.DataAnnotations;
using Framework.Core.Messages;
using Framework.Core.DomainObjects;
using CatalogService.Domain.DomainEvents;
using CatalogService.Domain.Models.Entities.Ids;

namespace CatalogService.Application.Commands.Purchase
{
    public class ConfirmCommand : Command<ConfirmCommandOutput>
    {
        [Required]
        public TransactionStockId TransactionStockId {get;set;}

        public ConfirmCommand(  TransactionStockId transactionStockId,
                               CorrelationId correlationId ):base(correlationId)
        {
            this.TransactionStockId = transactionStockId;

            this.AddRollBackEvent(new TransactionStockConfirmedCompensationEvent(this.TransactionStockId, this.CorrelationId));
        }
    }

    public class ConfirmCommandOutput : OutputCommand
    {
        public TransactionStockId TransactionStockId { get;  set; }

    }
}
