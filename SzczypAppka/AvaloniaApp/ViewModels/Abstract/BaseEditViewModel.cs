using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApp.ViewModels
{
	public abstract class BaseEditViewModel<T> : BaseViewModel where T : class
	{
		protected BaseEditViewModel(int itemId, string displayTitle = "")
			: base(displayTitle) 
		{
			ItemId = itemId;
			CancelCommand = new AsyncRelayCommand(OnCancel);
			SaveCommand = new AsyncRelayCommand(OnSave, ValidateSave);
			this.PropertyChanged += (_, __) => SaveCommand.NotifyCanExecuteChanged();
		}

		public T EditedItem { get; private set; }
		public IAsyncRelayCommand CancelCommand { get; }
		public IAsyncRelayCommand SaveCommand { get; }

		private int _itemId;
		public int ItemId
		{
			get { return _itemId; }
			set
			{
				_itemId = value;
				LoadItemId(value);
			}
		}
		public async void LoadItemId(int itemId)
		{
			try
			{
				EditedItem = await Context.FindAsync<T>(itemId);
				LoadProperties();
			}
			catch (Exception)
			{
				Debug.WriteLine("Failed to load edited item");
			}
		}
		protected abstract void LoadProperties();
		protected abstract T SetItem();
		protected abstract bool ValidateSave();
		protected async Task OnCancel()
		{
			//WeakReferenceMessenger.Default.Send(new ViewRequestMessage(MainWindowView.Cancel));
		}
		protected async Task OnSave()
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
	}
}
