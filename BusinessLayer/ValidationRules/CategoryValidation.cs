using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidation:AbstractValidator<Category>
    {
        public CategoryValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kategori adı boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(1).WithMessage("Minumum 99 karakter girilebilir.");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Maximum 100 karakter girilebilir.");
            
        }
    }
}
