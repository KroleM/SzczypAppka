namespace Database.Models
{
	public class Vaccine : DictionaryTable
	{
		// Name - nazwa handlowa
		public ICollection<IllnessVaccine> IllnessVaccines { get; set; } = new List<IllnessVaccine>();
		public ICollection<Scheme> Schemes { get; } = new List<Scheme>();
	}
}
