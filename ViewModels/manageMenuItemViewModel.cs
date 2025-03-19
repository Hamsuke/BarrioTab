using BarrioTab.Models;
using BarrioTab.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace BarrioTab.ViewModels;
public partial class manageMenuItemViewModel : ObservableObject
{
    [RelayCommand]
    private async Task editarInventario() => await Shell.Current.GoToAsync("AddItemPage");

    [RelayCommand]
    private async Task editarCategorias() => await Shell.Current.GoToAsync("AddCategoriaPage");

}
