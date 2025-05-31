namespace Database.Models
{
	public class Scheme : DictionaryTable
	{
		public int VaccineId { get; set; }
		public int PrimaryDoses { get; set; }
		public List<Dose> Doses { get; } = new List<Dose>();
	}
}
