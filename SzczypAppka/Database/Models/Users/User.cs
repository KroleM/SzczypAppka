namespace Database.Models
{
	public class User : DictionaryTable
	{
		public string FirstName { get; set; } = null!;
		public string? LastName { get; set; } = null!;
		public int Age { get; set; }
		public int AgeTypeId { get; set; }
		public virtual AgeType AgeType { get; set; }
		public int SexId { get; set; }
		public virtual Sex Sex { get; set; }
		public ICollection<Vaccination> Vaccinations { get; } = new List<Vaccination>();
		//Picture?
	}
}
