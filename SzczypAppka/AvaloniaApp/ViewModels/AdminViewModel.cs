using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaApp.ViewModels
{
	public partial class AdminViewModel : ViewModelBase
	{
		[ObservableProperty]
		string _title = "ZARZĄDZANIE";
	}
}
