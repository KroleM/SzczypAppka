using Database.Models;

namespace AvaloniaApp.ViewModels
{
	public class IllnessViewModel : BaseTableViewModel<Illness>
	{
		public IllnessViewModel(BaseListViewModel<Illness> listViewModel, BaseNewViewModel<Illness> newViewModel, string displayTitle = "") 
			: base(listViewModel, newViewModel, displayTitle)
		{
		}
	}
}
