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
            RuleFor(x => x.Title).NotEmpty().WithMessage( "Bölüm boş geçilemez.");
            RuleFor(x => x.SubTitle).NotEmpty().WithMessage( "Okul boş geçilemez.");
            RuleFor(x => x.NoteAverage).NotEmpty().WithMessage( "Lütfen not ortalamanızı yazınız ");
            RuleFor(x => x.Title).MaximumLength(200).MinimumLength(10).WithMessage("Lütfen geçerli bir Bölüm giriniz.");
            RuleFor(x => x.SubTitle).MaximumLength(200).MinimumLength(3).WithMessage("Lütfen geçerli bir Okul giriniz.");
       
        }
    }
}
