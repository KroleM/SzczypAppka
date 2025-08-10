using Avalonia;
using Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AvaloniaApp
{
	internal sealed class Program
	{
		public static IServiceProvider Services { get; private set; }

		// Initialization code. Don't use any Avalonia, third-party APIs or any
		// SynchronizationContext-reliant code before AppMain is called: things aren't initialized
		// yet and stuff might break.
		[STAThread]
		public static void Main(string[] args)
		{
			var serviceCollection = new ServiceCollection();
			ConfigureServices(serviceCollection);
			Services = serviceCollection.BuildServiceProvider();

			BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
		}

		// Avalonia configuration, don't remove; also used by visual designer.
		public static AppBuilder BuildAvaloniaApp()
			=> AppBuilder.Configure<App>()
				.UsePlatformDetect()
				.WithInterFont()
				.LogToTrace();

		private static void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<VacDatabaseContext>();
			//(options =>
			//	options.UseSqlServer(builder.Configuration.GetConnectionString("VacDatabaseContext")
			//	?? throw new InvalidOperationException("Connection string 'VacDatabaseContext' not found.")));

			// Add other services here
		}
	}
}
