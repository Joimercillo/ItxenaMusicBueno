using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ItxenaMusic
{
    public class ENTopDescargas
    {
        private List<ENCancion> canciones;

        public ENTopDescargas()
        {
            canciones = new List<ENCancion>();
        }

        public void anyadirCancion(ENCancion cancion)
        {
            canciones.Add(cancion);
        }

        public List<ENCancion> getCanciones(){
            return canciones;
        }


    }
}
