using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ItxenaMusic
{
    public class ENAlbum
    {
        private List<ENCancion> temas;
        private float precio;
        private List<string> autores;

        public ENAlbum()
        {
            temas = new List<ENCancion>();
            autores = new List<string>();
            precio = 0;
        }

        public float calcularPrecio()
        {
            float total = 0;
            foreach (ENCancion c in temas)
            {
                total += c.getPrecio();
            }
            return total;
        }

        public void anyadirTemas(ENCancion cancion){
            //Anaydimos cancion
            temas.Add(cancion);
        }

        public void anaydirAutores(string autor)
        {
            //Anyadimos autor
            autores.Add(autor);
        }

        public float getPrecio(){
            return precio;
        }

        public override string ToString()
        {
            return ""; 
        }

        public List<string> getAutores()
        {

            return autores;
        }

        public List<ENCancion> getTemas()
        {
            return temas;
        }



    }
}
