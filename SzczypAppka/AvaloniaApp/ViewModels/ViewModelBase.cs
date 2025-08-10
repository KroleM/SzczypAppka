using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaApp.ViewModels
{
	public abstract partial class ViewModelBase : ObservableObject
	{
		[ObservableProperty]
		bool _isBusy = false;

		//[ObservableProperty]
		//string _title = string.Empty;
	}
}
