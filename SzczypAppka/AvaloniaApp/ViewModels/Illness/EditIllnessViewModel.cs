using CommunityToolkit.Mvvm.ComponentModel;
using Database.Models;
using System;

namespace AvaloniaApp.ViewModels
{
	public partial class EditIllnessViewModel : BaseEditViewModel<Database.Models.Illness>
	{
		public EditIllnessViewModel(int itemId) 
			: base(itemId, "Edycja choroby")
		{
		}

		[ObservableProperty]
		string _name = string.Empty;

		[ObservableProperty]
		string _description = string.Empty;

		[ObservableProperty]
		bool _isActive = false;

		protected override void LoadProperties()
		{
			Name = EditedItem.Name;
			Description = EditedItem.Description;
			IsActive = EditedItem.IsActive;
		}

		protected override Illness SetItem()
		{
			return new Database.Models.Illness()
			{
				Id = ItemId,
				Name = _name,
				Description = _description,
				IsActive = _isActive,
				ModifiedDate = DateTimeOffset.Now,
			};
		}

		protected override bool ValidateSave()
		{
			return true;
		}
	}
}
