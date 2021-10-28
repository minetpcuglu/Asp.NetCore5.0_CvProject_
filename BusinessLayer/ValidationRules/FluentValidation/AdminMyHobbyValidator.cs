using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
   public class AdminMyHobbyValidator:AbstractValidator<MyHobby>
    {
        public AdminMyHobbyValidator()
        {
            RuleFor(x => x.Hobby).NotEmpty().WithMessage("İlgi  Alanı boş geçilemez.");
            RuleFor(x => x.Hobby).MaximumLength(200).MinimumLength(10).WithMessage("Lütfen geçerli bir ilgi alanı giriniz.");
        }
    }
}
