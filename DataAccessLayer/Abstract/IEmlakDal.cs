using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
	public interface  IEmlakDal:IGenericDal<Emlak>
	{
		//List<Emlak> getListEmlak();
        List<Emlak> getListEmlakTips();
        List<Emlak> getListEmlakTips(int id);
        // List<Emlak> getListEmlak();
    }
}
