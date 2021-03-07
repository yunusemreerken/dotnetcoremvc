﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace first_project.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
