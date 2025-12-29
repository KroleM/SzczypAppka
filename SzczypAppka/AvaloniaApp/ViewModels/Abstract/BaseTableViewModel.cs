using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace AvaloniaApp.ViewModels
{
	public partial class BaseTableViewModel<T> : TableViewModel where T : Database.Models.BaseDatatable
	{
		//[ObservableProperty]
		//DatabaseViewModel? _currentViewModel;

		[ObservableProperty]
		BaseListViewModel<T>? _listViewModel;

		[ObservableProperty]
		BaseNewViewModel<T>? _newViewModel;

		//edit?

		//public ICommand OpenListCommand { get; }
		//public ICommand OpenNewCommand { get; }

		public BaseTableViewModel(BaseListViewModel<T> listViewModel, BaseNewViewModel<T> newViewModel, string displayTitle = "")
		{
			DisplayTitle = displayTitle;
			ListViewModel = listViewModel;
			NewViewModel = newViewModel;
			CurrentViewModel = ListViewModel;
		}
	}
}
