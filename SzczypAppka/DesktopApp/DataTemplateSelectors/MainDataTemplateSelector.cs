using DesktopApp.ViewModels;
using DesktopApp.Views;

namespace DesktopApp.DataTemplateSelectors
{
	public class MainDataTemplateSelector : DataTemplateSelector
	{
		public DataTemplate ApplicationDataTemplate { get; set; }

		protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
		{
			if (item is ApplicationViewModel)
				return ApplicationDataTemplate;


			return ApplicationDataTemplate;
		}
	}
}
