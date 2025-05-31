using System.ComponentModel.DataAnnotations;

namespace Database.Models
{
	public abstract class DictionaryTable : BaseDatatable
	{
		[Required(ErrorMessage = "Name is required.")]
		[MaxLength(200)]
		public string Name { get; set; } = null!;
		public string? Description { get; set; } = null!;
	}
}
