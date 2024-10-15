using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Yonetici
	{
		[Key]
		public int YoneticiID { get; set; }

		public string YoneticiAdi { get; set; }

		public string YoneticiSoyadi {  get; set; }

		public int YoneticiTel {  get; set; }

		public string YoneticiMail {  get; set; }

		public string YoneticiUnvan {  get; set; }

		public List<Emlak> Emlaks { get; set; }

	}
}
