using DataAccessLayer.Concreate.Repositories;
using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Concreate
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAllBL()
        {
            return repo.Display();
        }
        public void CategoryAddBL(Category p)
        {
            if(p.CategoryName=="" || p.CategoryName.Length<=3 || p.CategoryDescription=="" || p.CategoryName.Length>=51)
            {
                //hata mesajı


            }
            else
            {
                repo.Insert(p);
            }
        } 
    }
}
