using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.UI.Areas.Author.Models
{
    public class ChangePasswordModel
    {
        [Required(ErrorMessage ="Zorunludur")]
        [DataType(DataType.Password,ErrorMessage ="Şifre formatında olmak zorunda")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "Zorunludur")]
        [DataType(DataType.Password, ErrorMessage = "Şifre formatında olmak zorunda")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Zorunludur")]
        [DataType(DataType.Password, ErrorMessage = "Şifre formatında olmak zorunda")]
        public string ConfirmedPassword { get; set; }
    }
}
