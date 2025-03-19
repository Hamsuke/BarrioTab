using System.Collections.ObjectModel;
using BarrioTab.Models;
using BarrioTab.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BarrioTab.ViewModels;
    
public partial class AddCategoriaViewModel : ObservableObject
{
    public ObservableCollection<Categorias> cat { get; set; } = new ObservableCollection<Categorias>();
    private readonly DataBaseService _data;
    public AddCategoriaViewModel(DataBaseService data)
    {
        _data = data;
    }

    [RelayCommand]
    public async Task CargaLista()
    {
        cat.Clear();
        var tmp = await _data.GetCategoriasAsync();
        foreach (var item in tmp)
        {
            cat.Add(item);
        }
    }

    [RelayCommand]
    public async Task AgregaCategoria(string nombre)
    {
        if (string.IsNullOrWhiteSpace(nombre))
            return;
        var newCat = new Categorias { nombre = nombre };
        await _data.InsertCategoriaAsync(newCat);
        cat.Add(newCat);
    }

    [RelayCommand]
    public async Task EliminaCategoria(Categorias categoria)
    {
        await _data.DeleteCategoriaAsync(categoria);
        cat.Remove(categoria);
    }

}