using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Student
    {
        [Required(ErrorMessage ="isminizi girin.")]
        public string Name { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "lütfen email adresinizi düzgün bir şekilde giriniz.")]
        public string Email { get; set; }
        [Required(ErrorMessage ="lütfen telefon numaranızı doğru bir şekilde yazın.")]
        public string Phone { get; set; }
        public bool? WillAttend { get; set; }

    }
}
