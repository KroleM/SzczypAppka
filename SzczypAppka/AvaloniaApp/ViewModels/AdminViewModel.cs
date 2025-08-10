﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace AvaloniaApp.ViewModels
{
	public partial class AdminViewModel : ViewModelBase
	{
		[ObservableProperty]
		string _title = "ZARZĄDZANIE";

		[ObservableProperty]
		ViewModelBase _currentViewModel;

		public ICommand OpenAllIllnessesCommand { get; }
		public ICommand OpenNewIllnessCommand { get; }

		public AdminViewModel()
		{
			OpenAllIllnessesCommand = new RelayCommand(OnOpenAllIllnesses);
			OpenNewIllnessCommand = new RelayCommand(OnOpenNewIllness);
		}

		#region Private methods
		private void OnOpenAllIllnesses()
		{
			CurrentViewModel = new NewIllnessViewModel();
		}
		private void OnOpenNewIllness()
		{
			CurrentViewModel = new NewIllnessViewModel();
		}
		#endregion
	}
}
