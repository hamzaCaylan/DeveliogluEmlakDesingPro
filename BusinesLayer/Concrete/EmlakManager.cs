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
	public class EmlakManager : IEmlakDal
	{
		IEmlakDal _emlakDal;

		public EmlakManager(IEmlakDal emlakDal)
		{
			_emlakDal = emlakDal;
		}		
		

		public void Delete(Emlak t)
		{
			_emlakDal.Delete(t);
		}

		public Emlak GetByID(int id)
		{
			return _emlakDal.GetByID(id);
		}

		public List<Emlak> GetListAll()
		{
			return _emlakDal.GetListAll();
		}

		public void Insert(Emlak t)
		{
			_emlakDal.Insert(t);
		}

		public void Update(Emlak t)
		{
			_emlakDal.Update(t);
		}
	}
}
