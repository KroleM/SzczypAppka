using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AvaloniaApp.ViewModels
{
	public partial class BaseTableViewModel<T> : ViewModelBase where T : Database.Models.BaseDatatable
	{
		[ObservableProperty]
		DatabaseViewModel? _currentViewModel;

		[ObservableProperty]
		ObservableCollection<ButtonViewModel> _tableCRUDs = new();

		[ObservableProperty]
		BaseListViewModel<T>? _listViewModel;

		[ObservableProperty]
		BaseNewViewModel<T>? _newViewModel;

		public ICommand OpenListCommand { get; }
		public ICommand OpenNewCommand { get; }

		//edit?

		public BaseTableViewModel(
			BaseListViewModel<T> listViewModel, 
			BaseNewViewModel<T> newViewModel, 
			string displayTitle = "")
		{
			DisplayTitle = displayTitle;
			ListViewModel = listViewModel;
			NewViewModel = newViewModel;
			CurrentViewModel = ListViewModel;

			TableCRUDs.Add(new ButtonViewModel(listViewModel.DisplayTitle, new RelayCommand(() => CurrentViewModel = ListViewModel)));
			TableCRUDs.Add(new ButtonViewModel(NewViewModel.DisplayTitle, new RelayCommand(() => CurrentViewModel = NewViewModel)));
		}
	}
}
