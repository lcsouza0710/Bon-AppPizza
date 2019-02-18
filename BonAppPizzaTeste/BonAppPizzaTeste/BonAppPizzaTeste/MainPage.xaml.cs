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

        async void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Estabel_Page());
        }
    }
}
