using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidation:AbstractValidator<Contact>
    {
        public ContactValidation()
        {
            RuleFor(x => x.Email).EmailAddress().WithMessage("Email formatı uygun değil");
            RuleFor(x => x.FullName).NotEmpty().WithMessage("Ad soyad alanı boş geçilemez");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Lütfen mesajınızı yazınız");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu alanı boş geçilemez");
        }
    }
}
