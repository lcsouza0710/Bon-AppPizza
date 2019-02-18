using BonAppPizzaTeste.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BonAppPizzaTeste
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Estabel_Page : ContentPage
	{

		public Estabel_Page ()
		{
            Estabelecimento EstabelecimentoTeste = new Estabelecimento();
            Cores cores = new Cores();
            BindingContext = EstabelecimentoTeste;
            BindingContext = cores;
            InitializeComponent ();
		}

        async void OnCardapioButtonClicked(object sender, EventArgs args)
        {

        }
    }
}