using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Abstract
{
    public interface IEmlakservice 
    {
        void EmlakAdd(Emlak emlak);
        void EmlakDelete(Emlak emlak);
        void EmlakUpdate(Emlak emlak);

        
        Emlak GetById(int id);

        List<Emlak> GetListWithEmlakTips();
        List<Emlak> GetList();
    }
}
