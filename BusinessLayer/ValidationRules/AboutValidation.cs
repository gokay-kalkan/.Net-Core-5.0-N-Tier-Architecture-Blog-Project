using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class AboutValidation:AbstractValidator<About>
    {
        public AboutValidation()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Hakkımda alanı boş geçilemez");
            RuleFor(x => x.Description).MaximumLength(500).WithMessage("Max 500 karakter uzunuluğunda olabilir.");
        }
    }
}
