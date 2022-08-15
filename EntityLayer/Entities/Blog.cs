using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
   public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
        public string BlogImage { get; set; }
        public int ReadCount { get; set; }
        public DateTime BlogDate { get; set; }
        public bool Status { get; set; }
        public int Rating { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual List<Comment> Comments { get; set; }

        public string  UserAdminId { get; set; }
        public virtual  UserAdmin UserAdmin { get; set; }
    }
}
