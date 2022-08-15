using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.UI.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Boş geçilemez")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
