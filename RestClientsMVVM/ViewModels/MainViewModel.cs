using System.Collections.ObjectModel;
using System.Windows.Input;
using RestClientsMVVM.Models;
using RestClientsMVVM.Services;
using Microsoft.Maui.Controls;
using RestClientsMVVM.Views;

namespace RestClientsMVVM.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private ObservableCollection<Cliente> _clientes;
        private Cliente _selectedCliente;
        private readonly ClienteDatabase _clienteDatabase;

        public ObservableCollection<Cliente> Clientes
        {
            get => _clientes;
            set => SetProperty(ref _clientes, value);
        }

        public Cliente SelectedCliente
        {
            get => _selectedCliente;
            set
            {
                SetProperty(ref _selectedCliente, value);
                ((Command)EditClienteCommand).ChangeCanExecute();
                ((Command)DeleteClienteCommand).ChangeCanExecute();
            }
        }

        public ICommand AddClienteCommand { get; }
        public ICommand EditClienteCommand { get; }
        public ICommand DeleteClienteCommand { get; }

        public MainViewModel(ClienteDatabase clienteDatabase)
        {
            _clienteDatabase = clienteDatabase;

            Clientes = new ObservableCollection<Cliente>();
            AddClienteCommand = new Command(OnAddCliente);
            EditClienteCommand = new Command(OnEditCliente, () => SelectedCliente != null);
            DeleteClienteCommand = new Command(OnDeleteCliente, () => SelectedCliente != null);

            LoadClientes();
        }

        private async void LoadClientes()
        {
            var clientes = await _clienteDatabase.GetClientesAsync();
            Clientes.Clear(); // Limpa a lista antes de adicionar os clientes recuperados do banco de dados
            foreach (var cliente in clientes)
            {
                Clientes.Add(cliente);
            }
        }

        private async void OnAddCliente()
        {
            await Shell.Current.GoToAsync(nameof(ClientePage));
        }

        private async void OnEditCliente()
        {
            if (SelectedCliente == null)
                return;

            await Shell.Current.GoToAsync($"{nameof(ClientePage)}?clientId={SelectedCliente.Id}");
        }

        private async void OnDeleteCliente()
        {
            if (SelectedCliente != null)
            {
                await _clienteDatabase.DeleteClienteAsync(SelectedCliente);
                Clientes.Remove(SelectedCliente);
                SelectedCliente = null;
            }
        }

        public void RefreshClientes()
        {
            LoadClientes();
        }
    }
}
