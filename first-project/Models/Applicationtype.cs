﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace first_project.Models
{
    public class Applicationtype
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
