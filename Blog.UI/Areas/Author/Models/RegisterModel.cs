using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.UI.Areas.Author.Models
{
    public class RegisterModel
    {
        public string Id { get; set; }
        [Required(ErrorMessage ="Boş geçilemez")]
        [EmailAddress(ErrorMessage ="Uygun formatta giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        [DataType(DataType.Password,ErrorMessage ="Uygun formatta giriniz.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        [DataType(DataType.Password, ErrorMessage = "Uygun formatta giriniz.")]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor")]
        public string RePassword { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        public string FullName { get; set; }
    }
}
