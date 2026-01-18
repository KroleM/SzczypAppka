using System.Linq;

namespace AvaloniaApp.ViewModels
{
	public class ListVaccineViewModel : BaseListViewModel<Database.Models.Vaccine>
	{
		public ListVaccineViewModel() 
			: base("Lista szczepionek")
		{
			ItemsCollection = new(Context.Vaccine.OrderBy(i => i.Name));    //Include: IllnessVaccines, Scheme?
		}
	}
}
