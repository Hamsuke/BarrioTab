using System.Collections.ObjectModel;
using System.ComponentModel;
using BarrioTab.Models;
using BarrioTab.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BarrioTab.ViewModels;
public partial class MainPageViewModel : ObservableObject
{
    //Variables de control
    private int seleccion = 0;
    private bool _initialized;
    //Colecciones de datos
    public ObservableCollection<Almacen> menu { get; set; } = new ObservableCollection<Almacen>();
    public ObservableCollection<Categorias> categorias { get; set; } = new ObservableCollection<Categorias>();
    //Interfaz de datos
    private readonly DataBaseService _data;
    public MainPageViewModel(DataBaseService data)
    {
        _data = data;
    }
    
    [RelayCommand]
    public async Task ReloadData()
    {
        categorias.Clear();
        menu.Clear();
        var tmp = await _data.GetAlmacenAsync();
        foreach (var item in tmp)
        {
            menu.Add(item);
        }
        var tmp2 = await _data.GetCategoriasAsync();
        foreach (var item in tmp2)
        {
            categorias.Add(item);
        }
    }
    [RelayCommand]
    public async Task GetMenuPorCategoria(int categoria)
    { 
        if (categoria == seleccion)
        {
            return;
        }
        else
        {
            menu.Clear();
            if (categoria == 1)
            {
                var tmp = await _data.GetAlmacenAsync();
                foreach (var item in tmp)
                {
                    menu.Add(item);
                }
            }
            else
            {
                var tmp = await _data.GetAlmacenCategoria(categoria);
                foreach (var item in tmp)
                {
                    menu.Add(item);
                }
            }
            seleccion = categoria;
        }
    }
    public async ValueTask InicializaAync()
    {
        if (_initialized)
            return; // Already initialized

        _initialized = true;

        categorias.Clear();
        menu.Clear();
        var tmp = await _data.GetAlmacenAsync();
        foreach (var item in tmp)
        {
            menu.Add(item);
        }
        var tmp2 = await _data.GetCategoriasAsync();
        foreach (var item in tmp2)
        {
            categorias.Add(item);
        }
        seleccion = categorias[0].id;
    }

}
