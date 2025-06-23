using System.ComponentModel.DataAnnotations;
using Framework.Core.DomainObjects;
using Framework.Shared.IntegrationEvent.Enums;
using MongoDB.Driver.Core.Operations;
using CatalogService.Domain.DomainEvents;
using CatalogService.Domain.Models.Entities.Ids;


namespace CatalogService.Domain.Models.Entities
{
    public class PriceStock : AggregateRoot, IAggregateRoot
    {

        public PriceStockId PriceStockId{get;set;}
        public decimal Regular {get;set;}
        public decimal RegularDayHigh {get;set;}
        public decimal RegularDayLow {get;set;}
        public int RegularVolume{get;set;}
        public DateTime ReferenceTime{get;set;}

        public static PriceStock Create(decimal Regular, decimal RegularDayHigh, decimal RegularDayLow, int RegularVolume, DateTime ReferenceTime){
            return new PriceStock(Regular, RegularDayHigh, RegularDayLow, RegularVolume, ReferenceTime);
        }

        protected PriceStock()
        {

        }

        private PriceStock(decimal Regular, decimal RegularDayHigh, decimal RegularDayLow, int RegularVolume, DateTime ReferenceTime){
            this.PriceStockId = new PriceStockId(Guid.NewGuid());
            this.Regular = Regular;
            this.RegularDayHigh = RegularDayHigh;
            this.RegularDayLow = RegularDayLow;
            this.RegularVolume = RegularVolume;
            this.ReferenceTime = ReferenceTime;
        }

        protected override void When(IDomainEvent @event)
        {
            throw new NotImplementedException();
        }
    }
}
