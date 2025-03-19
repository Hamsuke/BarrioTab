using BarrioTab.ViewModels;

namespace BarrioTab.Views;

public partial class manageMenuItemPage : ContentPage
{
	public manageMenuItemPage(manageMenuItemViewModel manageMenuItemViewModel)
	{
		InitializeComponent();
		BindingContext = manageMenuItemViewModel;
    }
}