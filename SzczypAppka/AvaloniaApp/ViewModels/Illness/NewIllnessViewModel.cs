using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Database.Context;
using Database.Models;
using System;
using System.Threading.Tasks;

namespace AvaloniaApp.ViewModels
{
	public partial class NewIllnessViewModel : ViewModelBase
	{
		private readonly VacDatabaseContext _vacDatabaseContext;    //DbContext??
		public NewIllnessViewModel()
		{
			_vacDatabaseContext = new VacDatabaseContext();
			SaveCommand = new AsyncRelayCommand(Save);
		}

		[ObservableProperty]
		string _name;

		[ObservableProperty]
		string _description;

		[ObservableProperty]
		bool _isActive = true;

		public IAsyncRelayCommand SaveCommand { get; }
		private async Task Save()
		{
			var newIllness = new Illness()
			{
				Name = _name,
				Description = _description,
				IsActive = _isActive,
				CreatedDate = DateTimeOffset.Now,
				ModifiedDate = DateTimeOffset.Now,
			};

			await _vacDatabaseContext.AddAsync(newIllness);
		}
	}
}
