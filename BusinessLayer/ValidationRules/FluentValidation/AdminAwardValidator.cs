using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
   public class AdminAwardValidator:AbstractValidator<Award>
    {
        public AdminAwardValidator()
        {
            RuleFor(x => x.AwardName).NotEmpty().WithMessage("Ödül/Başarı Alanı boş geçilemez.");
            RuleFor(x => x.AwardName).MaximumLength(200).MinimumLength(10).WithMessage("Lütfen geçerli bir Ödül/Başarı giriniz.");
        }
    }
}
