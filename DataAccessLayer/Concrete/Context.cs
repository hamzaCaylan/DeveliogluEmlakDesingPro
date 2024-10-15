using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
	internal class Context: DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//baglanti metni
			optionsBuilder.UseSqlServer("server=DESKTOP-RUFTLDI\\SQLEXPRESS;database=CoreDeveliogluEmlakDb;integrated security=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");
		}
		//context db setleri

		public DbSet<BolgeMahalle> BolgeMahalles { get; set; }

		public DbSet<Emlak> Emlaks { get; set; }

		public DbSet<EmlakTip> EmlakTips { get; set;}

		public DbSet<EmlakTur>	EmlakTurs { get; set; }

		public DbSet<Yonetici> Yoneticis { get; set;}





	}
}
