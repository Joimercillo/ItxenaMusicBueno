using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ItxenaMusic
{
    public class ENArtista
    {
        private int ID; 
        private string nombre;
        
        

        private List<ENCancion> canciones;
        private List<ENAlbum> albumes;

        public ENArtista(int ID, string nombre,List<ENCancion> canciones, List<ENAlbum> albumes)
        {
            this.ID = ID;
            this.nombre = nombre;
            this.canciones = canciones;
            this.albumes = albumes;
            
        }

        public void anyadirCancion(ENCancion cancion){
            canciones.Add(cancion);
        }

        public void anyadirAlbumnes(ENAlbum album)
        {
            albumes.Add(album);
        }

        public string getNombre()
        {
            return nombre;
        }

        public string ToSTring()
        {
            return "";
        }


        public List<ENCancion> getCanciones()
        {
            return canciones;
        }

        public List<ENAlbum> getAlbumnes()
        {
            return albumes;
        }

        public ArrayList mostrarArtistas()
        {
            ArrayList a = new ArrayList();
            
            return a;
        }



    }
}
