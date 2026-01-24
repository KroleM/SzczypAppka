using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Database.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

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

		public Database.Models.Vaccine SetItem()
		{
			// 1. Dodanie choroby do IllnessVaccines
			// 2. Dodanie schematu
			// 3. Zwrócenie Vaccine



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

		protected override async Task UpdateDatabase()
		{
			var vaccine = SetItem();

			using (var dbContextTransaction = Context.Database.BeginTransaction())
			{
				await Context.AddAsync(vaccine);	//bez await?
				await Context.SaveChangesAsync();

				if (!CurrentIllnesses.IsNullOrEmpty())
				{
					foreach (var illness in CurrentIllnesses)
					{
						Context.IllnessVaccine.Add(new IllnessVaccine
						{
							Id = 0,
							IsActive = true,
							IllnessId = illness.Id,
							VaccineId = vaccine.Id,
						});
						await Context.SaveChangesAsync();
					}
				}
				dbContextTransaction.Commit();
			}
		}
	}
}
