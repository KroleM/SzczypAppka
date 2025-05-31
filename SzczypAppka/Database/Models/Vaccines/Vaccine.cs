namespace Database.Models
{
	public class Vaccine : DictionaryTable
	{
		// Name - nazwa handlowa
		public int IllnessId { get; set; }
		public virtual Illness Illness { get; set; } = null!;
		public ICollection<Scheme> Schemes { get; } = new List<Scheme>();
	}
}
