using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ItxenaMusic
{
    public class ENTopCanciones
    {
        private List<ENCancion> canciones;
        //Las mas puntuadas

        public ENTopCanciones()
        {
            canciones = new List<ENCancion>();
        }

        public void anyadirCancion(ENCancion cancion)
        {
            canciones.Add(cancion);
        }

        public override string ToString()
        {
            return "";
        }

        public List<ENCancion> getCanciones()
        {
            return canciones;
        }
    }
}
