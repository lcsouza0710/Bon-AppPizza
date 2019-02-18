using BonAppPizzaTeste_Ooui.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BonAppPizzaTeste_Ooui.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            Cores coresPadrao = new Cores();

            BackgroundColor = coresPadrao.VermelhoPadrao;

            var logo = new Image
            {
                Source = ImageSource.FromFile("Images/logo.png")
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
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))
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
                Text = "Ainda não tem uma conta no Bon'App Pizza? Crie uma agora... É rápido!",
                TextColor = Color.White,
                LineBreakMode = LineBreakMode.WordWrap,
                HorizontalTextAlignment = TextAlignment.Center
            };


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
                    lblCriarConta
                }

            };

            RelativeLayout relativeLayout = new RelativeLayout();

            relativeLayout.Children.Add(stackLayout,
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.X + parent.Width / 3;
                }
                ),
                Constraint.Constant(15),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width / 2;
                }
                ),
                Constraint.Constant(200)
                );


            this.Content = relativeLayout;

        }

    }
}
