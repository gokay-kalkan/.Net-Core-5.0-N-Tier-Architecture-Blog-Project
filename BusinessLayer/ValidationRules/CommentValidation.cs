using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class CommentValidation:AbstractValidator<Comment>
    {
        public CommentValidation()
        {
            RuleFor(x => x.FullName).NotEmpty().WithMessage("Ad soyad alanı boş geçilemez");
            RuleFor(x => x.CommentText).NotEmpty().WithMessage("Yroumunuz boş geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş geçilemez");
            
        }
    }
}
