using System;
using Xamarin.Forms;

namespace BonAppPizzaTeste
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            var paginaInicial = new PaginaInicialCliente();
            Navigation.PushAsync(paginaInicial);
        }
    }
}
