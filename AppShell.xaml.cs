using BarrioTab.Views;

namespace BarrioTab
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            RegisterForRoute<AddItemPage>();
            RegisterForRoute<AddCategoriaPage>();
        }

        protected void RegisterForRoute<T>()
        {
            Routing.RegisterRoute(typeof(T).Name, typeof(T));
        }
    }
}
