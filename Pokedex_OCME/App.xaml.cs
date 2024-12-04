using Pokedex_OCME.Vista.Pokemon;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pokedex_OCME
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new RegistrarPokemon());

            MainPage = new NavigationPage(new ListaPokemon());
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
