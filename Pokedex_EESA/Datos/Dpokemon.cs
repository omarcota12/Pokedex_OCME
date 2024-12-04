using System;
using System.Collections.Generic;
using System.Text;
using Pokedex_OCME.Modelo;
using Pokedex_OCME.Conexion;
using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Collections.ObjectModel;
using System.Reactive.Linq;
using Firebase.Database;

namespace Pokedex_OCME.Datos
{
    public class Dpokemon
    {
        public async Task Insertarpokemon(Mpokemon Parametros)
        {
            await Cconexion.firebase
                .Child("Pokemon")
                .PostAsync(new Mpokemon()
                {
                 Colorfondo = Parametros.Colorfondo,
                 Colorpoder = Parametros.Colorpoder,
                 icono = Parametros.icono,
                 Nombre = Parametros.Nombre,
                 NroOrden = Parametros.NroOrden,
                 Poder = Parametros.Poder,


                });
        }
        public async Task<ObservableCollection<Mpokemon>> MostrarPokemones()
        {
            // return (await Cconexion.firebase
            // .Child("Pokemon")
            //  .OnceAsync<Mpokemon>())
            //  .Select(item => new Mpokemon
            //{
            //    Idpokemon=item.Key,
            //  Nombre = item.Object.Nombre,
            //Colorfondo = item.Object.Colorfondo,
            //Colorpoder = item.Object.Colorpoder,
            //icono = item.Object.icono,
            //NroOrden = item.Object.NroOrden,
            //Poder = item.Object.Poder

            //}).ToList();
            var data = await Task.Run(() => Cconexion.firebase
            .Child("Pokemon")
            .AsObservable<Mpokemon>()
            .AsObservableCollection());
            return data;
        }
    }
}
