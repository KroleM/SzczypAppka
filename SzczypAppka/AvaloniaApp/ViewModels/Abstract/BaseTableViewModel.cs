using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaApp.ViewModels
{
	public partial class BaseTableViewModel<T> : ViewModelBase where T : Database.Models.BaseDatatable
	{
		[ObservableProperty]
		DatabaseViewModel? _currentViewModel;

		[ObservableProperty]
		BaseListViewModel<T>? _listViewModel;

		[ObservableProperty]
		BaseNewViewModel<T>? _newViewModel;

		//edit?

		public BaseTableViewModel(BaseListViewModel<T> listViewModel, BaseNewViewModel<T> newViewModel, string displayTitle = "")
		{
			DisplayTitle = displayTitle;
			ListViewModel = listViewModel;
			NewViewModel = newViewModel;
			CurrentViewModel = ListViewModel;
		}
	}
}
