using System.Linq;

namespace AvaloniaApp.ViewModels
{
	public class ListVaccineViewModel : BaseListViewModel<Database.Models.Vaccine>
	{
		public ListVaccineViewModel() 
			: base("Szczepionki")
		{
			ItemsCollection = new(Context.Vaccine.OrderBy(i => i.Name));    //FIXME uogólnić + wczytywanie tylko określonej liczby rekordów (np. 20)
		}
	}
}
