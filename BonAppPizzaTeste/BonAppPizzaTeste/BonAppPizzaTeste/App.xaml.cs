using BonAppPizzaTeste.Models;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace BonAppPizzaTeste
{
    public partial class App : Application
        
    {
        public App()
        {

            InitializeComponent();

            List<Pais> listaPaises = new List<Pais>
            {
                new Pais(1, "Brasil")
            };

            List<Estado> listaEstados = new List<Estado>
            {
                new Estado(2, "Acre", "AC"),
                new Estado(3, "Alagoas", "AL"),
                new Estado(4, "Amapá", "AP"),
                new Estado(5, "Amazonas", "AM"),
                new Estado(6, "Bahia", "BA"),
                new Estado(7, "Ceará", "CE"),
                new Estado(8, "Distrito Federal", "DF"),
                new Estado(9, "Espírito Santo", "ES"),
                new Estado(10, "Goiás", "GO"),
                new Estado(11, "Maranhão", "MA"),
                new Estado(12, "Mato Grosso", "MT"),
                new Estado(13, "Mato Grosso do Sul", "MS"),
                new Estado(14, "Minas Gerais", "MG"),
                new Estado(15, "Pará", "PA"),
                new Estado(16, "Paraíba", "PB"),
                new Estado(17, "Paraná", "PB"),
                new Estado(18, "Pernambuco", "PE"),
                new Estado(19, "Piauí", "PI"),
                new Estado(20, "Rio de Janeiro", "RJ"),
                new Estado(21, "Rio Grande do Norte", "RN"),
                new Estado(22, "Rio Grande do Sul", "RS"),
                new Estado(23, "Rondônia", "RO"),
                new Estado(24, "Roraima", "RR"),
                new Estado(25, "Santa Catarina", "SC"),
                new Estado(1, "São Paulo", "SP"),
                new Estado(26, "Sergipe", "SE"),
                new Estado(27, "Tocantins", "TO")
            };

            List<Municipio> listaMunicipios = new List<Municipio>
            {
                new Municipio(1, "São Paulo"),
                new Municipio(2, "Itapecerica da Serra"),
                new Municipio(3, "Niterói")
            };

            List<TpLogradouro> listaTiposLogradouros = new List<TpLogradouro>
            {
                new TpLogradouro(1, "Rua"),
                new TpLogradouro(2, "Estrada"),
                new TpLogradouro(3, "Avenida"),
                new TpLogradouro(4, "Viela"),
                new TpLogradouro(5, "Passagem")
            };

            List<Endereco> listaEnderecos = new List<Endereco]>
            {

            };

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        
    }
}
