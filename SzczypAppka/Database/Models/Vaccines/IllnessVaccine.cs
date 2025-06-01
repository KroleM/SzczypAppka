namespace Database.Models
{
	public class IllnessVaccine : BaseDatatable
	{
		public int IllnessId { get; set; }
		public virtual Illness Illness { get; set; } = null!;
		public int VaccineId { get; set; }
		public virtual Vaccine Vaccine { get; set; } = null!;
	}
}
