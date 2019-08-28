using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProxyServer.Models
{
	public class ApplicationContext : IdentityDbContext<User>
	{
		public ApplicationContext(DbContextOptions<ApplicationContext> options)
			: base(options)
		{

		}


		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			//builder.Entity<Favorite>().HasKey(k => new { k.Id, k.UserId });
		}
		public DbSet<BitcoinPayment> BitcoinPayments { get; set; }
		public DbSet<IP> IPs { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Subscribe> Subscribes { get; set; }
		public DbSet<City> Cities { get; set; }
		public DbSet<CountProxyDays> CountProxyDays { get; set; }
		public DbSet<AppSetting> AppSettings { get; set; }
		public DbSet<Pravila> Pravila { get; set; }
		public DbSet<Preimush> Preimush { get; set; }
		public DbSet<Politica> Politica { get; set; }
	}
}
