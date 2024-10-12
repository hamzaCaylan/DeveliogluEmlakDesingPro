using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public  class Block
	{
		//emlak ilan liste elemanlarini iceriyor
		public int BlockID { get; set; }

		public string BlockName { get; set; }

		public string Bloccontent { get; set; }

		public string BlockCreateDate {get; set; }

	}
}
