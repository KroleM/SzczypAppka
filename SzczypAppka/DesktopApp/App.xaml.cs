using DesktopApp.ViewModels;

namespace DesktopApp
{
	public partial class App : Application
	{
		public App(MainViewModel mainViewModel)
		{
			InitializeComponent();

			MainPage = new MainPage(mainViewModel);
		}
	}
}
