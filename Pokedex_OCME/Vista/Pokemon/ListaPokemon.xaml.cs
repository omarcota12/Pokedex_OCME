﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokedex_OCME.VistaModelo.VMPokemon;
using Pokedex_OCME.Vista.Pokemon;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pokedex_OCME.Vista.Pokemon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaPokemon : ContentPage
    {
        public ListaPokemon()
        {
            InitializeComponent();
            BindingContext = new VMlistapokemon(Navigation);
           
        }

 

    }
}