using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ItxenaMusic
{
    public class ENColleccion
    {
           private List<ENCancion> canciones;

           public ENColleccion()
           {
               canciones = new List<ENCancion>();

           }
           
           public void AddCancion(ENCancion cancion){
               canciones.Add(cancion);
           }

           public override string  ToString()
           {
               StringBuilder stringBuilder = new StringBuilder();
               foreach (ENCancion Aux in canciones)
               {
                   stringBuilder.Append(Aux.ToString() + "\n");
               }

               return stringBuilder.ToString();

           }

           public List<ENCancion> getCanciones()
           {
               return canciones;
           }

           

           

           
    }
}
