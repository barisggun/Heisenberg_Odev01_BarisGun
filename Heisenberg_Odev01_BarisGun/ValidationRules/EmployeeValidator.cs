using FluentValidation;
using Heisenberg_Odev01_BarisGun.Models;

namespace Heisenberg_Odev01_BarisGun.ValidationRules
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.FirstName).MaximumLength(40).WithMessage("Adınız maksimum 40 karakter olmalıdır").MinimumLength(3).WithMessage("Adınız minimum 3 karakter olmalıdır.");

            RuleFor(x => x.LastName).MaximumLength(40).WithMessage("Adınız maksimum 40 karakter olmalıdır").MinimumLength(3).WithMessage("Adınız minimum 3 karakter olmalıdır.");

            RuleFor(x => x.Title).MaximumLength(40).WithMessage("Ünvanınız maksimum 40 karakter olmalıdır").MinimumLength(3).WithMessage("Ünvanınız minimum 3 karakter olmalıdır.");

            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Ad boş geçilemez");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Soyad boş geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Ünvan boş geçilemez");
        }
    }
}
