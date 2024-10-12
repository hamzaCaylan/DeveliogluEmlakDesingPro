using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Category
	{
		//property tanimla
		//erisim belirleyici -degisken-isim -getset

		public int CategoryID { get; set; }

		public string CategoryName { get; set; }

		public string CategoryDescription { get; set; }

		public bool CategoryStatus { get; set; }
	}
}
