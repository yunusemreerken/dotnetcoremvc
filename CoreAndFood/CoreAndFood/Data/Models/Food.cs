using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Data.Models
{
    public class Food
    {
        [Key]
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public int Stock { get; set; }
        //ilişkiler
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
