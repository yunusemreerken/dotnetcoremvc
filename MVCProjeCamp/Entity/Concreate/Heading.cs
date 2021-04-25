using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Concreate
{
    public class Heading
    {
        [Key]
        public int HeadingId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }


        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public ICollection<Content> Contents { get; set; }
    }
}
