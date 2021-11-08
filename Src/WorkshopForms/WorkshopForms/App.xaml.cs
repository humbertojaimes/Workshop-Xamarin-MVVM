using System;
using WorkshopForms.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkshopForms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage define la página con la que inicia la App
            //NavigationPage nos permite mostrar la barra de navegación
            //sin embargo su función principal es permitir la navegación
            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
