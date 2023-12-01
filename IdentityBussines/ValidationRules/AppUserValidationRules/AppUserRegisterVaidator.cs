using FluentValidation;
using IdentityDtoLayer.Dtos.AppUserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityBussines.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterVaidator:AbstractValidator<AppserRegisterDtos>
    {
        public AppUserRegisterVaidator()
        {
            RuleFor(n => n.Name).NotEmpty().WithMessage("Ad Alanı Boş Geçilemez");
            RuleFor(n => n.SurName).NotEmpty().WithMessage("Soyad Alanı Boş Geçilemez");
            RuleFor(n => n.UserName).NotEmpty().WithMessage("Ad Alanı Boş Geçilemez");
            RuleFor(n => n.Email).NotEmpty().WithMessage("kullanıcı Alanı Boş Geçilemez");
            RuleFor(n => n.Password).NotEmpty().WithMessage("Şifre Alanı Boş Geçilemez");
            RuleFor(n => n.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar Alanı Boş Geçilemez");
            RuleFor(n => n.Name).MaximumLength(30).WithMessage("En 30 Karakter  girin");
            RuleFor(n => n.Name).MaximumLength(30).WithMessage("En 2 Karakter  girin");
            RuleFor(n => n.Email).EmailAddress().WithMessage("Ad Alanı Boş Geçilemez");
        }
    }
}
