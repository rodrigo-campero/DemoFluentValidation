using DemoFluentValidation.Domain.Entities;
using FluentValidation;

namespace DemoFluentValidation.Domain.Validators
{
    public class CompanyValidator : AbstractValidator<Company>
    {
        public CompanyValidator()
        {
            RuleFor(m => m.Name).NotEmpty().NotNull();
        }
    }
}
