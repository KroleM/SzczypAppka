namespace Database.Models
{
	public class Vaccination : DictionaryTable
	{
		public int UserId { get; set; }
		public int IllnessId { get; set; }
		public virtual Illness Illness { get; set; } = null!;
		//user
		//lista dat szczepień
		//nazwa szczepionki
	}
}
