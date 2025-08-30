using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace AvaloniaApp.ViewModels
{
	public abstract partial class BaseListViewModel<T> : BaseViewModel
	{
		//FIXME wymaga dopracowania!
		// Sortowanie, filtrowanie ?

		[ObservableProperty]
		ObservableCollection<T> _itemsCollection;

		[ObservableProperty]
		private T? _selectedItem;

		protected BaseListViewModel(string displayTitle = "")
			: base(displayTitle)
		{

		}
	}
}
