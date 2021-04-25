using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal:IRepository<Category>
    {
        //crud işlemlerinin gerçekleşeceği metotları tanımladık.
        //type name();//metot yapısının açıklaması (on interface)
        //List<Category> Display();

        //void Insert(Category p);

        //void Update(Category p);

        //void Delete(Category p);
        //repository olmadan önce tek tek tanımlamak gerekiyordu artık gerek kalmadı.
    }
}
