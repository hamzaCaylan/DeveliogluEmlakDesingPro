using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Emlak
	{
		[Key]
		public int EmlakID { get; set; }

		public string EmlakName { get; set; }

		public string EmlakOda { get; set; }

		public int EmlakMetreKare { get; set;}

		public int EmlakKat { get; set; }

		public string EmlakAsansor {  get; set; }

		public string EmlakOtopark {  get; set; }

		public string EmlakIsitma {  get; set; }

		public string EmlakEsya {get; set; }

		public string EmlakYayinda {  get; set; }

		public string EmlakAciklama {  get; set; }

		public string Fiyat { get; set; }

		public string Kredi { get; set; }

		public string TapuDurum { get; set; }

		public string KonutYas { get; set; }

		public string Cephe { get; set; }


		public int BolgeMahalleID { get; set; }

        public BolgeMahalle BolgeMahalles { get; set; }


        public int YoneticiID { get; set; }

        public Yonetici Yoneticis { get; set; }


        public int EmlakTurID { get; set; }

        public EmlakTur EmlakTurs { get; set; }


        public int EmlakTipID { get; set; }

        public EmlakTip EmlakTips { get; set; }

		public List<Image> Images { get; set; }


	}
}
