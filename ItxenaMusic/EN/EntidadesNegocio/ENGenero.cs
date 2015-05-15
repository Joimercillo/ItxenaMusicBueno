using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ItxenaMusic
{
    public class ENGenero
    {
        private List<ENCancion> canciones;

        //TOP canciones segun su genero
        public ENGenero()
        {
            canciones = new List<ENCancion>();
        }

        private void anyadirCanciones(ENCancion cancion){
                //anaydir cancion
            canciones.Add(cancion);
        }

        public List<ENCancion> getCanciones()
        {
            return canciones;
        }
    }
}
