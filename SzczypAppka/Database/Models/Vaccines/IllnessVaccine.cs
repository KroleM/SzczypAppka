namespace Database.Models
{
	public class IllnessVaccine : BaseDatatable
	{
		public int IllnessId { get; set; }
		public Illness? Illness { get; set; }	//virtual?
		public int VaccineId { get; set; }
		public Vaccine? Vaccine { get; set; }	//virtual?
	}
}
