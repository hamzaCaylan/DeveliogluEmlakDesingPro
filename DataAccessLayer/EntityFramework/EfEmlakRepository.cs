using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfEmlakRepository : GenericRepository<Emlak>, IEmlakDal
    {	

		 public List<Emlak> getListEmlakTips()
         {
            using (var c = new Context())
            {
                
                return c.Emlaks.Include(a => a.BolgeMahalles).Include(a => a.EmlakTips).Include(a => a.EmlakTurs).Include(a => a.Yoneticis).ToList();

            } 
         }

        public List<Emlak> getListEmlakTips(int id)
        {
            using (var c = new Context())
            {

                return c.Emlaks.Include(a => a.BolgeMahalles).Include(a => a.EmlakTips).Include(a => a.EmlakTurs).Include(a => a.Yoneticis).Where(a=>a.EmlakID==id).ToList();

            }
        }
    }
}