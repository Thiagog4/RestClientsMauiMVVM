using Microsoft.Extensions.DependencyInjection;
using RestClientsMVVM.ViewModels;
using RestClientsMVVM.Views;
using RestClientsMVVM.Services;
using System.IO;

namespace RestClientsMVVM
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            // Configurar o caminho do banco de dados
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "Clientes.db3");

            // Registrar ViewModels e Views
            builder.Services.AddSingleton<ClienteDatabase>(s => ActivatorUtilities.CreateInstance<ClienteDatabase>(s, dbPath));
            builder.Services.AddSingleton<MainViewModel>();
            builder.Services.AddTransient<ClienteViewModel>();

            builder.Services.AddSingleton<MainPage>((s) => new MainPage(s.GetRequiredService<MainViewModel>())); // Registrar MainPage com MainViewModel
            builder.Services.AddTransient<ClientePage>();

            return builder.Build();
        }
    }
}
