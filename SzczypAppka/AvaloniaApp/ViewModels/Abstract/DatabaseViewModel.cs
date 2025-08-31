using Database.Context;

namespace AvaloniaApp.ViewModels
{
	public abstract partial class DatabaseViewModel : ViewModelBase
	{
		private readonly VacDatabaseContext _vacDatabaseContext;
		protected VacDatabaseContext Context => _vacDatabaseContext;
		
		protected DatabaseViewModel(string displayTitle)
		{
			_vacDatabaseContext = new VacDatabaseContext(); //FIXME Dependency Injection?
			DisplayTitle = displayTitle;
		}
	}
}
