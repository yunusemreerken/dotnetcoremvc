using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Data.Models;
namespace Library.Data
{
    public class ProductBusinessLogic
    {
        private Context c;
        public ProductBusinessLogic()
        {
            c = new Context();
        }
        public IQueryable<Category> GetProducts(CategorySearch categoryModel)
        {
            var result = c.Categories.AsQueryable();
            if (categoryModel != null)
            {
               
                if (!string.IsNullOrEmpty(categoryModel.CategoryName))
                    result = result.Where(x => x.CategoryName.Contains(categoryModel.CategoryName));
                if (!string.IsNullOrEmpty(categoryModel.CategoryDescription))
                    result = result.Where(x => x.CategoryDescription.Contains(categoryModel.CategoryDescription));
            }
            return result;
        }
    }
}
