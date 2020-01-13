using DemoFluentValidation.Domain.Validators;
using FluentValidation.TestHelper;
using Xunit;

namespace DemoFluentValidation.Domain.Test.Entities
{
    public class CompanyTest
    {
        private readonly CompanyValidator _validator;

        public CompanyTest()
        {
            _validator = new CompanyValidator();
        }

        [Fact]
        public void Valid_ObjectIsValid_()
        {
           var result = _validator.ShouldHaveValidationErrorFor(c => c.Name, string.Empty);
        }
    }
}
