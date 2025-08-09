using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AvaloniaApp.ViewModels
{
	public partial class MainWindowViewModel : ViewModelBase
	{
		[ObservableProperty]
		ViewModelBase _workingAreaViewModel;

		public ICommand SetAdminViewCommand { get; }
		public ICommand SetOptionsViewCommand { get; }

		public MainWindowViewModel()
		{
			SetAdminViewCommand = new RelayCommand(OnSetAdminView);
			SetOptionsViewCommand = new RelayCommand(OnSetOptionsView);
		}

		#region Private methods
		private void OnSetAdminView()
		{
			WorkingAreaViewModel = new AdminViewModel();
		}
		private void OnSetOptionsView()
		{
			WorkingAreaViewModel = new OptionsViewModel();
		}
		#endregion
	}
}
