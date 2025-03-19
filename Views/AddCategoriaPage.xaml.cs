using BarrioTab.ViewModels;

namespace BarrioTab.Views;

public partial class AddCategoriaPage : ContentPage
{
	private readonly AddCategoriaViewModel _viewModel;
    public AddCategoriaPage(AddCategoriaViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = _viewModel = viewModel;
    }
}