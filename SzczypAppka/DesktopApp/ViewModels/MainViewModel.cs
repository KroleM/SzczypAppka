using CommunityToolkit.Mvvm.ComponentModel;

namespace DesktopApp.ViewModels
{
	public partial class MainViewModel : BaseViewModel
	{

		AdminViewModel _adminViewModel;			//FIXME BaseViewModel?
		ApplicationViewModel _applicationViewModel;
		SettingsViewModel _settingsViewModel;

		/// <summary>
		/// Serves as a view-model for the right-hand view
		/// and changes between Application, Admin and Settings.
		/// </summary>
		[ObservableProperty]
		BaseViewModel _workingViewModel;

		public MainViewModel()
		{
			Title = "SzczypAppka";
			_applicationViewModel = new ApplicationViewModel();
			WorkingViewModel = _applicationViewModel;
		}
	}
}
