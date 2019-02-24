using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BonAppPizzaTeste
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            Cores coresPadrao = new Cores();


            BackgroundColor = coresPadrao.VermelhoPadrao;

            /*
            Slider slider = new Slider
            {
                Maximum = 100,

            };



            Label valueSlider = new Label
            {
                TextColor = Color.White
            };
            */
            

            var logo = new Image
            {
                Source = ImageSource.FromFile("logo.png"),
                WidthRequest = 128,
                HeightRequest = 128
            };

            Entry entryLogin = new Entry
            {
                TextColor = Color.White,
                Placeholder = "Login",
                PlaceholderColor = coresPadrao.BrancoOpaco,
                Keyboard = Keyboard.Email
            };

            Entry entrySenha = new Entry
            {
                TextColor = Color.White,
                Placeholder = "Senha",
                PlaceholderColor = coresPadrao.BrancoOpaco,
                IsPassword = true,
                Keyboard = Keyboard.Text
            };

            Label dicaLogin = new Label
            {
                Text = "Email ou número de telefone",
                TextColor = Color.White,
                FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label))
            };

            Label dicaSenha = new Label
            {
                Text = "Mínimo de 6 caracteres",
                TextColor = Color.White,
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))
            };

            Button btnEntrar = new Button
            {
                Text = "Entrar",
                TextColor = Color.White,
                BackgroundColor = coresPadrao.VerdePadrao
               
            };

            Label lblCriarConta = new Label
            {
                Text = "Ainda não tem uma conta no Bon'App Pizza? Crie uma agora... É super rápido!",
                TextColor = Color.White,
                LineBreakMode = LineBreakMode.WordWrap,
                HorizontalTextAlignment = TextAlignment.Center
            };

            Button btnFacebook = new Button
            {
                Text = "Entrar com o Facebook",
                TextColor = Color.White,
                BackgroundColor = Color.FromHex("#3B5998"),
            };

            Button btnGoogle = new Button
            {
                Text = "Entrar com o Google",
                TextColor = Color.White,
                BackgroundColor = Color.FromHex("#DD4B39")
            };

            /*

            var larguraStack = Width;


            Label lagrura = new Label
            {
                Text = larguraStack.ToString(),
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.Center
            };

            */

            StackLayout stackLayout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children =
                {
                    logo,
                    entryLogin,
                    dicaLogin,
                    entrySenha,
                    dicaSenha,
                    btnEntrar,
                    lblCriarConta,
                    btnFacebook,
                    btnGoogle
                    
                }
 
            };

            /*
            valueSlider.SetBinding(Label.TextProperty, new Binding("Value", source: slider));
            */

            AbsoluteLayout absoluteLayout = new AbsoluteLayout
            {
                Children =
                {
                    stackLayout
                }
            };

            AbsoluteLayout.SetLayoutFlags(stackLayout, AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(stackLayout, new Rectangle(.5, .2, .6, 1));

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = absoluteLayout,
                Padding = new Thickness(0,40,0,20)
            };

            this.Content = scrollView;


            //InitializeComponent();
        }
    }
}