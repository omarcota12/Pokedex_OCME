using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace Pokedex_OCME.Conexion
{
    class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://mvvmocme-default-rtdb.firebaseio.com/");
    }
}
