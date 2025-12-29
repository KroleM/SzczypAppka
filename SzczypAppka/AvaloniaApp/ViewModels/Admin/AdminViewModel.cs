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
		IllnessViewModel? _illnessViewModel;
		//BaseTableViewModel<Illness>? _illnessViewModel;

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

			Tables.Add(new ButtonViewModel("Choroby", new RelayCommand(OnOpenIlnessSection)));
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
		private void OnOpenIlnessSection()
		{
			if (IllnessViewModel is null)
			{
				IllnessViewModel = new(new AllIllnessesViewModel(), new NewIllnessViewModel());
			}
			CurrentAdminViewModel = IllnessViewModel;
		}
		#endregion
	}
}
