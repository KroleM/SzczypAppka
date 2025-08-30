using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AvaloniaApp.ViewModels
{
	public partial class AllIllnessesViewModel : BaseListViewModel<Database.Models.Illness>
	{
		public AllIllnessesViewModel()
			: base("Choroby")
		{
			ItemsCollection = new(Context.Illness.OrderBy(i => i.Name));	//FIXME uogólnić
		}
	}
}
