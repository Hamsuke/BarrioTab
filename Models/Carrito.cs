using CommunityToolkit.Mvvm.ComponentModel;

namespace BarrioTab.Models;
    public partial class Carrito : ObservableObject
    {
        public int item { get; set; }
        public string producto { get; set; }
        public decimal precio { get; set; }

        [ObservableProperty, NotifyPropertyChangedFor(nameof(Amount))]
        private int _cantidad;

        public decimal Amount => _cantidad * precio;
    }