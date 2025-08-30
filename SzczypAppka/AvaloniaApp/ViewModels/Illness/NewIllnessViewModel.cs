using CommunityToolkit.Mvvm.ComponentModel;
using System;

namespace AvaloniaApp.ViewModels
{
	public partial class NewIllnessViewModel : BaseNewViewModel<Database.Models.Illness>
	{
		public NewIllnessViewModel()
			: base("Nowa choroba")
		{
		}

		[ObservableProperty]
		string _name;

		[ObservableProperty]
		string _description;

		[ObservableProperty]
		bool _isActive = true;

		public override bool ValidateSave()
		{
			return true;
		}

		public override Database.Models.Illness SetItem()
		{
			return new Database.Models.Illness()
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
