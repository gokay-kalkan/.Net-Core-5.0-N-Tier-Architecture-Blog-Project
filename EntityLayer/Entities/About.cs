﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        public string Description { get; set; }
    }
}
