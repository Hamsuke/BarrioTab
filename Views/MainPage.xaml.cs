using BarrioTab.ViewModels;

namespace BarrioTab.Views;

public partial class MainPage : ContentPage
{
    private readonly MainPageViewModel _viewModel;

    public MainPage(MainPageViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
        Initialize();
    }

    private async void Initialize()
    {
        await _viewModel.InicializaAync();
    }
}
