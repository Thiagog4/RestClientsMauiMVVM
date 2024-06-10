using System;
using Microsoft.Maui.Controls;
using RestClientsMVVM.Models;
using RestClientsMVVM.ViewModels;

namespace RestClientsMVVM.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public MainPage(MainViewModel viewModel) : this()
        {
            BindingContext = viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (BindingContext is MainViewModel mainViewModel)
            {
                mainViewModel.RefreshClientes();
            }
        }
        private async void OnExcluirClienteClicked(object sender, EventArgs e)
        {
            var viewModel = BindingContext as MainViewModel;
            if (viewModel?.SelectedCliente != null)
            {
                bool result = await DisplayAlert("Excluir Cliente", $"Tem certeza que deseja excluir o cliente {viewModel.SelectedCliente.Name}?", "Sim", "Não");
                if (result)
                {
                    viewModel.DeleteClienteCommand.Execute(null);
                }
            }
            else
            {
                await DisplayAlert("Atenção", "Nenhum cliente selecionado para exclusão.", "OK");
            }
        }
    }
}
