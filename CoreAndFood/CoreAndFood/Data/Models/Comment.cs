using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Data.Models
{
    public class Comment
    {
        [Key]
        [Required]
        public int CommentId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="please enter the email adress")]
        public string Email { get; set; }
        [Required]
        [StringLength(50,ErrorMessage ="please enter max 50 character")]
        public string YourComment { get; set; }
    }
}
