using BarrioTab.Services;
using BarrioTab.ViewModels;
using BarrioTab.Views;
using CommunityToolkit.Maui;

namespace BarrioTab
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                // Initialize the .NET MAUI Community Toolkit by adding the below line of code
                .UseMauiCommunityToolkit()
                // After initializing the .NET MAUI Community Toolkit, optionally add additional fonts
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // Register the IDataServices as a singleton
            builder.Services.AddSingleton<DataBaseService>();

            // Register the Pages as a singleton
            builder.Services.AddSingleton<AddItemPage>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<AddCategoriaPage>();

            // Register the ViewModels as a singleton
            builder.Services.AddSingleton<manageMenuItemViewModel>();
            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddSingleton<AddCategoriaViewModel>();

            // Continue initializing your .NET MAUI App here

            return builder.Build();
        }
    }
}
