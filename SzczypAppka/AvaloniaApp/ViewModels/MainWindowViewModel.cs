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

		//FIXME może ten lazy-loading w getterze dałoby się zastąpić jakąś generyczną klasą, np. LazyViewModel<T>, która miałaby T Value?
		private AdminViewModel _adminViewModel;
		public AdminViewModel AdminViewModel 
		{ 
			get
			{
				if (_adminViewModel is null)
				{
					_adminViewModel = new AdminViewModel();
				}
				return _adminViewModel;
			}
		}

		private OptionsViewModel _optionsViewModel;
		public OptionsViewModel OptionsViewModel
		{
			get
			{
				if (_optionsViewModel is null)
				{
					_optionsViewModel = new OptionsViewModel();
				}
				return _optionsViewModel;
			}
		}

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
			WorkingAreaViewModel = AdminViewModel;
		}
		private void OnSetOptionsView()
		{
			WorkingAreaViewModel = OptionsViewModel;
		}
		#endregion
	}
}
