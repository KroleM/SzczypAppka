using CommunityToolkit.Mvvm.ComponentModel;

namespace DesktopApp.ViewModels
{
	public abstract partial class BaseViewModel : ObservableObject
	{
		[ObservableProperty]
		bool _isBusy = false;

		[ObservableProperty]
		string _title = string.Empty;
	}
}
