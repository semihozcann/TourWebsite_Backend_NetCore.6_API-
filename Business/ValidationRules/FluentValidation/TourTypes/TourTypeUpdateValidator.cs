using Entities.Dtos.TourTypes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation.TourTypes
{
    public class TourTypeUpdateValidator : AbstractValidator<TourTypeUpdateDto>
    {
        public TourTypeUpdateValidator()
        {
            RuleFor(t => t.Name)
                .NotEmpty()
                    .WithMessage("Lütfen isim alanını doldurunuz.")
                .NotNull()
                .MaximumLength(50)
                    .WithMessage("Lütfen 50 harften daha kısa bir isim giriniz.");
            RuleFor(t => t.Description)
                .NotEmpty()
                .NotNull()
                .MaximumLength(250)
                    .WithMessage("Lütfen 250 harften daha kısa bir isim giriniz.");
        }
    }
}
