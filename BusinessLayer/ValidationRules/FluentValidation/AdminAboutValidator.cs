using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
   public class AdminAboutValidator:AbstractValidator<About>
    {
        public AdminAboutValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim boş geçilemez.");
            RuleFor(x => x.Adress).NotEmpty().WithMessage("Adres boş geçilemez.");
            RuleFor(x => x.TelephoneNumber).NotEmpty().WithMessage("Telefon Numarası Giriniz.");
            RuleFor(x => x.DipNot).NotEmpty().WithMessage("Kendinden bahsetmediniz lütfen sizi tanıyabilmemiz için kendinizden bahsedin.");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail boş geçilemez.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş geçilemez.");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("Soyisim boş geçilemez.");
            RuleFor(x => x.Name).MaximumLength(25).MinimumLength(3).WithMessage("Lütfen geçerli bir isim giriniz.");
            RuleFor(x => x.SurName).MaximumLength(25).MinimumLength(3).WithMessage("Lütfen geçerli bir Soyisim giriniz.");
            RuleFor(x => x.Password).Must(IsPasswordValidRules).WithMessage("Parolanızda en az bir küçük harf bir büyük harf ve rakamdan oluşmalıdır.");


        }

        private bool IsPasswordValidRules(string arg)
        {
            try
            {
                Regex writerPassword = new Regex(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[0-9])[A-Za-z\d]");
                return writerPassword.IsMatch(arg);
            }
            catch
            {
                return false;
            }
        }
    }
}
