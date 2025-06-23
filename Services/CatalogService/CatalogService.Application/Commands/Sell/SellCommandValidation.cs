using FluentValidation;

namespace CatalogService.Application.Commands.Sell

{
    public class SellCommandValidation : AbstractValidator<SellCommand>
    {
        public SellCommandValidation()
        {
            RuleFor(c => c.Amount)
                .NotEmpty();

        }
    }
}
