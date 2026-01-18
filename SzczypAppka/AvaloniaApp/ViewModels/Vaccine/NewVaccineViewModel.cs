using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace AvaloniaApp.ViewModels
{
	public partial class NewVaccineViewModel : BaseNewViewModel<Database.Models.Vaccine>
	{
		public NewVaccineViewModel()
			: base("Nowa szczepionka")
		{
			AvailableIllnesses = new(Context.Illness.OrderBy(i => i.Name));
		}

		[ObservableProperty]
		string _name;

		[ObservableProperty]
		string _description;

		[ObservableProperty]
		bool _isActive = true;

		[ObservableProperty]
		List<Database.Models.Illness> _availableIllnesses;

		[ObservableProperty]
		Database.Models.Illness? _selectedIllness;

		[ObservableProperty]
		ObservableCollection<Database.Models.Illness> _currentIllnesses = new();

		public override bool ValidateSave()
		{
			return true;
		}

		public override Database.Models.Vaccine SetItem()
		{
			return new Database.Models.Vaccine()
			{
				Name = _name,
				Description = _description,
				IsActive = _isActive,
				CreatedDate = DateTimeOffset.Now,
				ModifiedDate = DateTimeOffset.Now,
				//IllnessVaccines
			};
		}

		[RelayCommand]
		void AddSelectedIllness()	//async?
		{
			if (SelectedIllness is null)
			{
				return;
			}
			if (CurrentIllnesses.Contains(SelectedIllness))
			{
				return;
			}

			CurrentIllnesses.Add(SelectedIllness);
			SelectedIllness = null;
		}
	}
}
