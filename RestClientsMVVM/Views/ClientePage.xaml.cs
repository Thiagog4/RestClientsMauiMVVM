using RestClientsMVVM.Models;
using RestClientsMVVM.Services;
using RestClientsMVVM.ViewModels;
using Microsoft.Maui.Controls;

namespace RestClientsMVVM.Views
{
    [QueryProperty(nameof(ClientId), "clientId")]
    public partial class ClientePage : ContentPage
    {
        private readonly ClienteViewModel _viewModel;
        private int clientId;
        private readonly ClienteDatabase _clienteDatabase;

        public ClientePage(ClienteDatabase clienteDatabase, ClienteViewModel viewModel)
        {
            InitializeComponent();
            _clienteDatabase = clienteDatabase;
            _viewModel = viewModel;
            BindingContext = _viewModel;
        }

        public int ClientId
        {
            get => clientId;
            set
            {
                clientId = value;
                LoadClient(value);
            }
        }

        private async void LoadClient(int clientId)
        {
            if (clientId == 0)
            {
                _viewModel.Cliente = new Cliente(); // Inicialize com um novo cliente
            }
            else
            {
                var cliente = await _clienteDatabase.GetClienteAsync(clientId);
                _viewModel.Cliente = cliente;
            }
        }
    }
}
