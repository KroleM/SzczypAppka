using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaApp.ViewModels
{
	public partial class OptionsViewModel : ViewModelBase
	{
		[ObservableProperty]
		string _text = "OPCJE";
	}
}
