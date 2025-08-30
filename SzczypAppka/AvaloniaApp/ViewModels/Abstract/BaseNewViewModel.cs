using CommunityToolkit.Mvvm.Input;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AvaloniaApp.ViewModels
{
	public abstract class BaseNewViewModel<T> : BaseViewModel
	{
		protected BaseNewViewModel(string displayTitle = "") 
			: base(displayTitle)
		{
			SaveCommand = new AsyncRelayCommand(OnSave, ValidateSave);
			CancelCommand = new AsyncRelayCommand(OnCancel);

			//this.PropertyChanged += (_, __) => SaveCommand.NotifyCanExecuteChanged();
		}

		public IAsyncRelayCommand CancelCommand { get; }
		public IAsyncRelayCommand SaveCommand { get; }
		public abstract T SetItem();
		public abstract bool ValidateSave();

		private async Task OnSave()
		{
			try
			{
				await Context.AddAsync(SetItem());
				await Context.SaveChangesAsync();
				//WeakReferenceMessenger.Default.Send(new ViewRequestMessage(MainWindowView.BackAndRefresh));
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
			}
		}
		private async Task OnCancel()
		{
			//WeakReferenceMessenger.Default.Send(new ViewRequestMessage(MainWindowView.Cancel));
		}
	}
}
