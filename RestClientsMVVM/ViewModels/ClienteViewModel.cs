using System.Windows.Input;
using RestClientsMVVM.Models;
using RestClientsMVVM.Services;
using Microsoft.Maui.Controls;
using RestClientsMVVM.Views;

namespace RestClientsMVVM.ViewModels
{
    public class ClienteViewModel : BaseViewModel
    {
        private Cliente _cliente;
        private readonly ClienteDatabase _clienteDatabase;

        public Cliente Cliente
        {
            get => _cliente;
            set => SetProperty(ref _cliente, value);
        }

        public ICommand SaveCommand { get; }
        public ICommand CancelCommand { get; }

        public ClienteViewModel(ClienteDatabase clienteDatabase)
        {
            _clienteDatabase = clienteDatabase;

            SaveCommand = new Command(OnSave);
            CancelCommand = new Command(OnCancel);

            Cliente = new Cliente(); // Inicialize com um novo cliente
        }

        public ClienteViewModel(ClienteDatabase clienteDatabase, int clienteId) : this(clienteDatabase)
        {
            LoadCliente(clienteId);
        }

        private async void LoadCliente(int clienteId)
        {
            Cliente = await _clienteDatabase.GetClienteAsync(clienteId);
        }

        private async void OnSave()
        {
            await _clienteDatabase.SaveClienteAsync(Cliente);
            NotifyMainPageToRefresh();
            await Shell.Current.GoToAsync("..");
        }

        private async void OnCancel()
        {
            NotifyMainPageToRefresh();
            await Shell.Current.GoToAsync("..");
        }

        private void NotifyMainPageToRefresh()
        {
            if (Shell.Current.Navigation.NavigationStack.FirstOrDefault() is MainPage mainPage &&
                mainPage.BindingContext is MainViewModel mainViewModel)
            {
                mainViewModel.RefreshClientes();
            }
        }
    }
}
