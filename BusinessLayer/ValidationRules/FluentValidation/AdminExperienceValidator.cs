using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
   public class AdminExperienceValidator:AbstractValidator<Experience>
    {
        public AdminExperienceValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Deneyim Alanı boş geçilemez.");
            RuleFor(x => x.Date).NotEmpty().WithMessage("Yıl Alanı boş geçilemez.");
            RuleFor(x => x.Title).MaximumLength(200).MinimumLength(10).WithMessage("Lütfen geçerli bir deneyim giriniz.");
        }
    }
}
