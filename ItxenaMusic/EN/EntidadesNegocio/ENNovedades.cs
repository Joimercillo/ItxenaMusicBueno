using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ItxenaMusic
{
    
    public class ENNovedades
    {
        private List<ENCancion> canciones;

        public ENNovedades(){
            canciones = new List<ENCancion>();
        }

        public void anyadirCanciones(ENCancion cancion){
            canciones.Add(cancion);
        }

        public override string ToString()
        {
            return "";
        }

        public void addCancion(ENCancion cancion)
        {
            canciones.Add(cancion);
        }

        public List<ENCancion> getCanciones()
        {
            return canciones;
        }
    }
}
