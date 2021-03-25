﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace CoreDepartman.Models
{
    public class Departman
    {
        [Key]
        public int Id { get; set; }
        public string DepartmanName { get; set; }

        public IList<Personel> Personels { get; set; }
    }
}
