﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Data.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-9A8NPH3\\SQLEXPRESS;database=Db_CoreFood; integrated security=true");

        }
        public DbSet<Food> Foods {get;set;}
        public DbSet<Category> Categories {get;set;}

        public DbSet<Admin> Admins {get;set;}

    }
}
