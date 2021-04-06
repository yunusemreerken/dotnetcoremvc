using Library.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.Models
{
    public class MemberBook
    {
        public int Book_Id { get; set; }
        public Book Book { get; set; }

        public int Member_Id { get; set; }
        public Member Member { get; set; }
    
        public string LoanedTime { get; set; }
    }
}
