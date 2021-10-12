using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
   public class AdminAbilityValidator:AbstractValidator<Ability>
    {
        public AdminAbilityValidator()
        {
            RuleFor(x => x.MyAbility).NotEmpty().WithMessage("Yetenek Alanı boş geçilemez.");
            RuleFor(x => x.MyAbility).MaximumLength(200).MinimumLength(10).WithMessage("Lütfen geçerli bir yetenek giriniz.");
        }
    }
}
