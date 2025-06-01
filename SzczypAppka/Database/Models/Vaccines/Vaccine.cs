namespace Database.Models
{
	public class Vaccine : DictionaryTable
	{
		// Name - nazwa handlowa
		public virtual ICollection<IllnessVaccine> IllnessVaccines { get; set; } = new List<IllnessVaccine>();
		public virtual ICollection<Scheme> Schemes { get; } = new List<Scheme>();
	}
}
