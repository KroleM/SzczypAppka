namespace Database.Models
{
	public class Vaccination : DictionaryTable
	{
		public int UserId { get; set; }
		public int IllnessId { get; set; }
		public virtual Illness Illness { get; set; } = null!;
		public int? VaccineId { get; set; }
		public virtual Vaccine? Vaccine { get; set; }
		public bool IsCompleted { get; set; }
		public DateTimeOffset CompletionData { get; set; }
		public ICollection<UserDose> UserDoses { get; } = new List<UserDose>();
		//lista dat szczepień
		//nazwa szczepionki
	}
}
