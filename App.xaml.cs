using BarrioTab.Services;

namespace BarrioTab
{
    public partial class App : Application
    {

        public App(DataBaseService dataBaseService)
        {
            InitializeComponent();
            MainPage = new AppShell();

            Task.Run(async () => await dataBaseService.InicializaBasedeDatosAsync())
                .GetAwaiter()
                .GetResult();
        }
    }
}