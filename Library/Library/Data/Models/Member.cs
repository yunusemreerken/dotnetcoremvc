using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Library.Data;

namespace Library.Data.Models
{
    public class Member
    {
        [Key]
        public int Member_Id { get; set; }
        public string Member_Name { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string  Image { get; set; }
        public int IdentityNumber { get; set; }
        public string Password { get; set; }

        public int MyProperty { get; set; }
        //ilşikiler
        public  List<MemberBook> MemberBooks  { get; set; }


    }
}
