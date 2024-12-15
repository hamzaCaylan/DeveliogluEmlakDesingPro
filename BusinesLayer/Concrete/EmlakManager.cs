using BusinesLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Concrete
{
    public class EmlakManager : IEmlakservice
    {
        IEmlakDal _emlakDal;

        public EmlakManager(IEmlakDal emlakDal)
        {
            _emlakDal = emlakDal;
        }

        public void EmlakAdd(Emlak emlak)
        {
            _emlakDal.Insert(emlak);
        }

        public void EmlakDelete(Emlak emlak)
        {
            _emlakDal.Delete(emlak);
        }

        public void EmlakUpdate(Emlak emlak)
        {
            _emlakDal.Update(emlak);
        }
        public List<Emlak> GetListWithEmlakTips()
        {
            return _emlakDal.getListEmlakTips();
        }

        public Emlak GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Emlak> GetList()
        {
            throw new NotImplementedException();

        }


    }
}
