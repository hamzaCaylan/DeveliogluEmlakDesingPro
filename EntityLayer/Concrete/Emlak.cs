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

		public bool EmlakAsansor {  get; set; }

		public bool EmlakOtopark {  get; set; }

		public string EmlakIsitma {  get; set; }

		public bool EmlakEsya{get; set; }

		public bool EmlakYayinda {  get; set; }

		public string EmlakAciklama {  get; set; }

        public int BolgeMahalleID { get; set; }

        public BolgeMahalle BolgeMahalles { get; set; }

        public int YoneticiID { get; set; }

        public Yonetici Yoneticis { get; set; }

        public int EmlakTurID { get; set; }

        public EmlakTur EmlakTurs { get; set; }

        public int EmlakTipID { get; set; }

        public EmlakTip EmlakTips { get; set; }
        


    }
}
