using BusinesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Concrete
{
    public class YoneticiManager : IYoneticiServices
    {
        IYoneticiDal _yoneticiDal;

        public YoneticiManager(IYoneticiDal yoneticiDal)
        {
            _yoneticiDal = yoneticiDal;
        }

        public void YoneticiAdd(Yonetici yonetici)
        {
           _yoneticiDal.Insert(yonetici);
        }
    }
}
