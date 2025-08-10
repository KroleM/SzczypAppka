using CommunityToolkit.Mvvm.ComponentModel;
using Database.Context;
using Database.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace AvaloniaApp.ViewModels
{
	public partial class AllIllnessesViewModel : ViewModelBase
	{
		private readonly VacDatabaseContext _context;    //DbContext??

		[ObservableProperty]
		ObservableCollection<Illness> _illnesses;

		public AllIllnessesViewModel()
		{
			_context = new VacDatabaseContext();
			_illnesses = new(_context.Illness.OrderBy(i => i.Name));
		}
	}
}
