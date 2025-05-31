namespace Database.Models
{
	public class Dose : DictionaryTable
	{
		public int SchemeId { get; set; }
		public int OrderNumber { get; set; }
		public TimeSpan TimeFromPreviousDose { get; set; }
	}
}
