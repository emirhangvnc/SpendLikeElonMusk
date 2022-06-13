using Business.Constants;
using Entities.DTOs.ProductDto;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation.ProductValidator
{
    public class ProductAddDtoValidator : AbstractValidator<ProductAddDto>
    {
        public ProductAddDtoValidator()
        {
            RuleFor(p => p.CategoryId).NotEmpty().WithMessage($"Kategori {Messages.NotEmpty}");
            RuleFor(p => p.ProductName).NotEmpty().WithMessage($"Ürün İsim {Messages.NotEmpty}");
            RuleFor(p => p.ProductName).MaximumLength(50).WithMessage($"Ürün İsim {Messages.Max50Caracter}");
            RuleFor(p=>p.ProductName).Must(IsValidName).WithMessage($"Ürün İsmi Metinsel İfade İçermelidir");
            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage($"Ürün Fiyat {Messages.NotEmpty}");
        }
        private bool IsValidName(string name)
        {
            return name.All(Char.IsLetter);
        }
    }
}