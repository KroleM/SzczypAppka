using CommunityToolkit.Mvvm.ComponentModel;

namespace DesktopApp.ViewModels
{
	public partial class MainViewModel : BaseViewModel
	{
		[ObservableProperty]
		BaseViewModel _additionalViewModel;

		public MainViewModel()
		{
			Title = "SzczypAppka";
			AdditionalViewModel = new AdditionalViewModel();
		}
	}
}
