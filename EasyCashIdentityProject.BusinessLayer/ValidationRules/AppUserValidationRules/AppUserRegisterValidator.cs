using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(a => a.Name).NotEmpty().WithMessage("İsim Alanı Boş Geçilemez!");
            RuleFor(a => a.Surname).NotEmpty().WithMessage("Soyisim Alanı Boş Geçilemez!");
            RuleFor(a => a.Username).NotEmpty().WithMessage("Kullanıcı Adı Alanı Boş Geçilemez!");
            RuleFor(a => a.Email).NotEmpty().WithMessage("E-Mail Alanı Boş Geçilemez!");
            RuleFor(a => a.Password).NotEmpty().WithMessage("Şifre Alanı Boş Geçilemez!");
            RuleFor(a => a.ConfirmPassword).NotEmpty().WithMessage("Şifre Tekrar Alanı Boş Geçilemez!");
            RuleFor(a => a.Name).MaximumLength(50).WithMessage("Lütfen En Fazla 30 Karakter Girişi Yapın!");
            RuleFor(a => a.Name).MinimumLength(2).WithMessage("Lütfen En Az 2 Karakter Girişi Yapın");
            RuleFor(a => a.ConfirmPassword).Equal(y => y.Password).WithMessage("Şifreler eşleşmedi!");
            RuleFor(a => a.Email).EmailAddress().WithMessage("Lütfen Geçerli Bir E-Mail Adresi Giriniz!");
        }
    }
}
