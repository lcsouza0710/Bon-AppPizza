using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BonAppPizzaTeste
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaInicialCliente : NavigationPage
    {
        public PaginaInicialCliente()
        {
            Cores cores = new Cores();
            this.BackgroundColor = cores.VerdePadraoFosco;
            InitializeComponent();
            //On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);         
        }
    }
}