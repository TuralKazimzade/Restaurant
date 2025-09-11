using FluentValidation;
using Restaurant.WebApi.Entities;

namespace Restaurant.WebApi.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Məhsul adı tələb olunur");
            RuleFor(p=> p.ProductName).MaximumLength(100).WithMessage("Məhsul adı maksimum 100 simvol ola bilər");
            RuleFor(p=>p.ProductName).MinimumLength(2).WithMessage("Məhsul adı minimum 2 simvol ola bilər");

            RuleFor(p => p.Price).NotEmpty().WithMessage("Qiymət tələb olunur").GreaterThan(0).WithMessage("Qiymət 0-dan kiçik ola bilməz")
                .LessThan(1000).WithMessage("Qiymət 1000-dən yuxarı ola bilməz");

            RuleFor(p => p.Description).NotEmpty().WithMessage("Təsvir tələb olunur");



        }
    }
}