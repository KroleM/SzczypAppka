using CommunityToolkit.Maui;
using DesktopApp.ViewModels;
using Microsoft.Extensions.Logging;

namespace DesktopApp
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.UseMauiCommunityToolkit()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				})
				.RegisterViewModels();

#if DEBUG
			builder.Logging.AddDebug();
#endif

			return builder.Build();
		}

		public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
		{
			mauiAppBuilder.Services.AddTransient<MainViewModel>();

			return mauiAppBuilder;
		}
	}
}
