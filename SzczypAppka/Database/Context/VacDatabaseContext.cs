using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Database.Context
{
	public sealed class VacDatabaseContext : DbContext
	{
		#region Constructor
		//public VacDatabaseContext(DbContextOptions<VacDatabaseContext> options) : base(options)
		//{
		//}
		#endregion

		#region DbSets
		public DbSet<User> User { get; set; }
		public DbSet<Vaccination> Vaccination { get; set; }
		public Illness Illness { get; set; }
		public Vaccine Vaccine { get; set; }
		public IllnessVaccine IllnessVaccine { get; set; }
		public Scheme Scheme { get; set; }
		public Dose Dose { get; set; }
		public UserDose UserDose { get; set; }
		#endregion
	}
}
