namespace Database.Models
{
	public class Illness : DictionaryTable
	{
		public virtual ICollection<IllnessVaccine> IllnessVaccines { get; set; } = new List<IllnessVaccine>();
	}
}
