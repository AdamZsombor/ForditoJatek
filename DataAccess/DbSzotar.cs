using Adam_Zsombor_beadando.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adam_Zsombor_beadando.DataAccess
{
	public class DbSzotar : DbContext
	{
		public DbSet<Szotar> Szotar { get; set; }

		public DbSzotar()
		{
			
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Szotar; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Szotar>()
				.ToTable("Szotar", "dbo")
				.HasKey("Id");

			modelBuilder.Entity<Szotar>()
				.Property("Id")
				.HasColumnName("Id")
				.HasColumnType("int")
				.IsRequired();

			modelBuilder.Entity<Szotar>()
				.Property("Eng")
				.HasColumnType("nvarchar")
				.HasColumnName("Eng")
				.HasMaxLength(200)
				.IsRequired();

			modelBuilder.Entity<Szotar>()
				.Property("Hun")
				.HasColumnType("nvarchar")
				.HasColumnName("Hun")
				.HasMaxLength(200)
				.IsRequired();
		}
	}
}
