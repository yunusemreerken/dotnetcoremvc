using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        //crud işlemlerinin gerçekleşeceği metotları tanımladık.
        //type name();//metot yapısının açıklaması (on interface)
        List<T> Display();

        void Insert(T p);

        void Update(T p);

        void Delete(T p);

        //şartlı listeleme için //filtreli
        List<T> List(Expression<Func<T, bool>> filter);
    }
}
