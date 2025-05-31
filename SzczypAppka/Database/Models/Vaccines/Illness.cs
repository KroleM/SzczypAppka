namespace Database.Models
{
	public class Illness : DictionaryTable
	{
		public ICollection<IllnessVaccine> IllnessVaccines { get; set; } = new List<IllnessVaccine>();
	}
}
