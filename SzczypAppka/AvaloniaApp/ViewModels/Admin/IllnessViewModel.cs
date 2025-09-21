using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaApp.ViewModels
{
	// Ta klasa będzie zarządzała widokami typu Illness (wszystkie, szczegóły, edycja, nowy)
	public partial class IllnessViewModel : ObservableObject
	{
		[ObservableProperty]
		DatabaseViewModel _mainIlnessViewModel; //czy będzie inny?

		//4 view-modele do widoków, żeby zachowywać ich stan?
		private AllIllnessesViewModel _listIllnessViewModel;
		public AllIllnessesViewModel ListIllnessViewModel
		{
			get
			{
				if (_listIllnessViewModel is null)
				{
					_listIllnessViewModel = new AllIllnessesViewModel();
				}
				return _listIllnessViewModel;
			}
		}

		private NewIllnessViewModel _newIllnessViewModel;
		public NewIllnessViewModel NewIllnessViewModel
		{
			get
			{
				if (_newIllnessViewModel is null)
				{
					_newIllnessViewModel = new NewIllnessViewModel();
				}
				return _newIllnessViewModel;
			}
		}

		//4 komendy do otwierania view-modeli (zatem też widoków)
	}
}
