using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string BookName { get; set; }
        [Required]
        public string Author { get; set; }
        public string Cilt { get; set; }
        [Required]
        public string PublisherName { get; set; }
        [Required]
        public string CoverType { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string CoverImage { get; set; }

        //ilişkiler
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual List<MemberBook> MemberBooks { get; set; }

    }
}
