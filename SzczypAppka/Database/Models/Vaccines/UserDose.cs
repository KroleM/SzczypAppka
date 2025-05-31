namespace Database.Models
{
	public class UserDose : DictionaryTable
	{
		public int VaccinationID { get; set; }
		//Dawka przypominająca może nie mieć odpowiednika w schemacie
		public int? DoseId { get; set; }
		public virtual Dose? Dose { get; set; } = null!;
		public DateTimeOffset PlannedDoseDate { get; set; }
		public DateTimeOffset DoseDate { get; set; }
		public bool IsCompleted { get; set; }
	}
}
