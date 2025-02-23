using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Abstract
{
    public interface IGernericServices<T>
    {
        //53.ders generic yapi
        void TAdd(T t);
        void TDelete(T t);
        void TUpdate(T t);
        
        List<T> GetList();

        T GetById(int id);

    }
}
