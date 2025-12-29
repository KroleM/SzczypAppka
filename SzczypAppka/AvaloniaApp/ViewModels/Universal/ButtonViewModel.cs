using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace AvaloniaApp.ViewModels
{
	public partial class ButtonViewModel : ViewModelBase
	{
		[ObservableProperty]
		string? _description;   //for ToolTip

		[ObservableProperty]
		bool _isClicked;

		public ICommand ButtonCommand { get; }

		public ButtonViewModel(string title, ICommand buttonCommand)
		{
			DisplayTitle = title;
			ButtonCommand = buttonCommand;
		}
	}
}
