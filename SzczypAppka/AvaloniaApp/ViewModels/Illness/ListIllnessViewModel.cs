using System.Linq;

namespace AvaloniaApp.ViewModels
{
	public class ListIllnessViewModel : BaseListViewModel<Database.Models.Illness>
	{
		public ListIllnessViewModel()
			: base("Lista chorób")
		{
			ItemsCollection = new(Context.Illness.OrderBy(i => i.Name));	//FIXME uogólnić; View-Modele do tabel BD?
		}
	}
}
