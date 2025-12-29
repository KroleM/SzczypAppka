using CommunityToolkit.Mvvm.ComponentModel;
using System;

namespace AvaloniaApp.ViewModels
{
	public partial class NewVaccineViewModel : BaseNewViewModel<Database.Models.Vaccine>
	{
		public NewVaccineViewModel()
			: base("Nowa szczepionka")
		{
		}

		[ObservableProperty]
		string _name;

		[ObservableProperty]
		string _description;

		[ObservableProperty]
		bool _isActive = true;

		//lista wszystkich chorób
		//lsita chorób przypisanych do szczepionki

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
			};
		}
	}
}
