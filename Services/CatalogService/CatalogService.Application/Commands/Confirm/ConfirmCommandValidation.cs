using FluentValidation;

namespace CatalogService.Application.Commands.Purchase
{
    public class ConfirmCommandValidation : AbstractValidator<ConfirmCommand>
    {
        public ConfirmCommandValidation()
        {
            RuleFor(c => c.TransactionStockId)
                .NotEmpty();

        }
    }
}
