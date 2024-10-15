using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class BolgeMahalle
	{
		[Key]
		public int BolgeMahalleID { get; set; }

		public string BolgeMahalleName { get; set; }

        public List<Emlak> Emlaks { get; set; }

		

	}
}
