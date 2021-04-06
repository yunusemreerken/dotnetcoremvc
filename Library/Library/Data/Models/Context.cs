using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-9A8NPH3\\SQLEXPRESS;database=DB_Library; integrated security=true;");
           
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories   { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<MemberBook> MemberBooks { get; set; }

        public DbSet<Message> Messages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
   
          
            
            modelBuilder.Entity<MemberBook>()
           .HasKey(t => new { t.Member_Id, t.Book_Id });

            modelBuilder.Entity<MemberBook>()
                .HasOne<Book>(pt => pt.Book)
                .WithMany(p => p.MemberBooks)
                .HasForeignKey(pt => pt.Book_Id);

            modelBuilder.Entity<MemberBook>()
                .HasOne<Member>(pt => pt.Member)
                .WithMany(t => t.MemberBooks)
                .HasForeignKey(pt => pt.Member_Id);
        }


    }
}
