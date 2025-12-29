using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace AvaloniaApp.ViewModels
{
	public partial class TableViewModel : ViewModelBase
	{
		[ObservableProperty]
		DatabaseViewModel? _currentViewModel;

		public ICommand OpenListCommand { get; }
		public ICommand OpenNewCommand { get; }
	}
}
