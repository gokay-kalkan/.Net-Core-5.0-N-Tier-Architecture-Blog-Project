using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.UI.Areas.Author.Models
{
    public class ResetPasswordModel
    {
        [Required(ErrorMessage ="Boş bırakılamaz")]
        [EmailAddress(ErrorMessage ="Uygun formatta değil")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Boş bırakılamaz")]
        [DataType(DataType.Password,ErrorMessage ="uygun formatta değil")]
        public string NewPassword { get; set; }
    }
}
