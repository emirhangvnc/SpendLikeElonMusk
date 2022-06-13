using Business.Constants;
using Entities.DTOs.ProductDto;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation.ProductValidator
{
    public class ProductUpdateDtoValidator : AbstractValidator<ProductUpdateDto>
    {
        public ProductUpdateDtoValidator()
        {
            RuleFor(p => p.ProductId).NotEmpty().WithMessage($"Ürün Id {Messages.NotEmpty}");
            RuleFor(p => p.CategoryId).NotEmpty().WithMessage($"Kategori {Messages.NotEmpty}");
            RuleFor(p => p.ProductName).NotEmpty().WithMessage($"Ürün İsim {Messages.NotEmpty}");
            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage($"Ürün Fiyat {Messages.NotEmpty}");
        }
    }
}