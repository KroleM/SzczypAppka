using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Database.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AvaloniaApp.ViewModels
{
	public partial class AdminViewModel : ViewModelBase
	{
		[ObservableProperty]
		ViewModelBase? _currentAdminViewModel;
		//DatabaseViewModel _currentAdminViewModel;

		[ObservableProperty]
		ObservableCollection<ButtonViewModel> _tables = new();

		[ObservableProperty]
		BaseTableViewModel<Illness>? _illnessViewModel;

		[ObservableProperty]
		BaseTableViewModel<Vaccine>? _vaccineViewModel;

		//4 categories: Illness, Vaccine, Scheme, Dose

		public ICommand OpenAllIllnessesCommand { get; }
		public ICommand OpenNewIllnessCommand { get; }

		public AdminViewModel()
		{
			DisplayTitle = "ZARZĄDZANIE";
			OpenAllIllnessesCommand = new RelayCommand(OnOpenAllIllnesses);
			OpenNewIllnessCommand = new RelayCommand(OnOpenNewIllness);

			Tables.Add(new ButtonViewModel("Choroby", new RelayCommand(OnOpenIllnessSection)));
			Tables.Add(new ButtonViewModel("Szczepionki", new RelayCommand(OnOpenVaccineSection)));
		}

		#region Private methods
		private void OnOpenAllIllnesses()
		{
			//CurrentViewModel = new AllIllnessesViewModel();
		}
		private void OnOpenNewIllness()
		{
			//CurrentViewModel = new NewIllnessViewModel();
		}
		private void OnOpenIllnessSection()
		{
			if (IllnessViewModel is null)
			{
				IllnessViewModel = new(new AllIllnessesViewModel(), new NewIllnessViewModel());
			}
			CurrentAdminViewModel = IllnessViewModel;
		}
		private void OnOpenVaccineSection()
		{
			if (VaccineViewModel is null)
			{
				VaccineViewModel = new(new ListVaccineViewModel(), new NewVaccineViewModel());
			}
			CurrentAdminViewModel = VaccineViewModel;
		}
		#endregion
	}
}
