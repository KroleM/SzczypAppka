using CommunityToolkit.Mvvm.ComponentModel;
using Database.Context;

namespace AvaloniaApp.ViewModels
{
	public abstract partial class BaseViewModel : ObservableObject
	{
		[ObservableProperty]
		bool _isBusy;

		[ObservableProperty]
		string _displayTitle;

		private readonly VacDatabaseContext _vacDatabaseContext;
		protected VacDatabaseContext Context => _vacDatabaseContext;
		
		protected BaseViewModel(string displayTitle)
		{
			_vacDatabaseContext = new VacDatabaseContext(); //FIXME Dependency Injection?
			_displayTitle = displayTitle;
		}
	}
}
