using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
   public class AdminEducationLifeValidator:AbstractValidator<EducationLife>
    {
        public AdminEducationLifeValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage( "boş geçilemez.");
            RuleFor(x => x.SubTitle).NotEmpty().WithMessage( "boş geçilemez.");
            RuleFor(x => x.Title).MaximumLength(200).MinimumLength(10).WithMessage("Lütfen geçerli bir yetenek giriniz.");
            RuleFor(x => x.SubTitle).MaximumLength(200).MinimumLength(3).WithMessage("Lütfen geçerli bir yetenek giriniz.");
       
        }
    }
}
