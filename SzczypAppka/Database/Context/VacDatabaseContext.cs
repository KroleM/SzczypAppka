using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Database.Context
{
	public sealed class VacDatabaseContext : DbContext
	{
		#region DbSets
		public DbSet<User> User { get; set; }
		public DbSet<Vaccination> Vaccination { get; set; }
		public DbSet<Illness> Illness { get; set; }
		public DbSet<Vaccine> Vaccine { get; set; }
		public DbSet<IllnessVaccine> IllnessVaccine { get; set; }
		public DbSet<Scheme> Scheme { get; set; }
		public DbSet<Dose> Dose { get; set; }
		public DbSet<UserDose> UserDose { get; set; }
		#endregion

		#region Methods
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=VacDatabase;Trusted_Connection=True;MultipleActiveResultSets=true;");
		}
		#endregion
	}
}
