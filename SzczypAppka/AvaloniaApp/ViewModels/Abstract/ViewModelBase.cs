using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaApp.ViewModels
{
	public abstract partial class ViewModelBase : ObservableObject
	{
		[ObservableProperty]
		bool _isBusy;

		[ObservableProperty]
		string _displayTitle = string.Empty;
	}
}
