using RestClientsMVVM.Views;

namespace RestClientsMVVM;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Definir rotas
        Routing.RegisterRoute(nameof(ClientePage), typeof(ClientePage));
    }
}
