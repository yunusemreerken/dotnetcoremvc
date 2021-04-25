using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Concreate
{
    public class Content
    {
        [Key]
        public int ContentId { get; set; }
        [StringLength(1000)]
        public string Value { get; set; }
        public DateTime ContentDate { get; set; }
        //contentauthor
        //content heading

        public int HeadingId { get; set; }
        public virtual Heading Heading { get; set; }
        public int? AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}
