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
    public class EmlakManager : IEmlakService
    {
        IEmlakDal _emlakDal;

        public EmlakManager(IEmlakDal emlakDal)
        {
            _emlakDal = emlakDal;
        }
        public void TAdd(Emlak t)
        {
            _emlakDal.Insert(t);
        }

        public void TDelete(Emlak t)
        {
            _emlakDal.Delete(t);
        }

        public void TUpdate(Emlak t)
        {
            _emlakDal.Update(t);
        }

        public List<Emlak> GetListWithEmlakTips()
        {
            return _emlakDal.getListEmlakTips();
        }

        public Emlak GetById(int id)
        {
           return _emlakDal.GetByID(id);
        }

        public List<Emlak> GetList()
        {
            return _emlakDal.GetListAll();

        }
        public List<Emlak> GetListWithEmlakTips(int id)
        {
            return _emlakDal.getListEmlakTips(id);
        }

        public List<Emlak> GetEmlakListByYonetici(int id)
        {
            return _emlakDal.GetListAll(x=>x.YoneticiID==id);
        }
        

        public List<Emlak> GetEmlakListByYoneticiBm(int id)
        {
            return _emlakDal.getListEmlakTipsByYontici(id);
        }



        //53.der kalkti
        //public void EmlakAdd(Emlak emlak)
        //{
        //    _emlakDal.Insert(emlak);
        //}

        //public void EmlakDelete(Emlak emlak)
        //{
        //    _emlakDal.Delete(emlak);
        //}

        //public void EmlakUpdate(Emlak emlak)
        //{
        //    _emlakDal.Update(emlak);
        //}
    }
}
