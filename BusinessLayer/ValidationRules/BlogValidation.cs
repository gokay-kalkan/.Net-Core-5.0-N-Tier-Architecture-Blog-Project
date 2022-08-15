using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
  public  class BlogValidation:AbstractValidator<Blog>
    {
        public BlogValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Blog adı boş geçilemez");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Blog açıklaması boş geçilemez");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Blog kategorisi boş geçilemez");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Blog resmi boş geçilemez");
          
        }
    }
}
