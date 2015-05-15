using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ItxenaMusic
{
    public class ENCarrito
    {
        private List<ENCancion> canciones;
        private List<ENAlbum> albumnes;
        private float precio;
        
        public ENCarrito()
        {
            precio = 0;
            canciones = new List<ENCancion>();
            albumnes = new List<ENAlbum>();
        }

        public void anyadirCanciones(ENCancion cancion)
        {
            canciones.Add(cancion);
            
        }

        public void borrarCanciones(ENCancion cancion)
        {
            //canciones.Remove(cancion);
        }

        public void anaydirAlbumnes(ENAlbum album)
        {
            albumnes.Add(album);
        }

        public void borrarAlbumenes(ENAlbum album)
        {

            //albumnes.Remove(album);
        }

        public void CalcularPrecio()
        {
            precio=0;
            foreach (ENAlbum aux in albumnes){
                precio += aux.getPrecio();
            }

            foreach (ENCancion aux in canciones)
            {
                precio += aux.getPrecio();
            }
        }

        public float getPrecio()
        {
            return precio;
        }

        public List<ENCancion> getCanciones()
        {
            return canciones;
        }

        public List<ENAlbum> getAlbumnes()
        {
            return albumnes;
        }
    }
}
