using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ItxenaMusic
{
   public  class ENConcierto
    {

        private float precio;
        private Lugar lugar;
        private string nombre;
        private string descripcion;
        private  List<ENArtista> artistas;
        private int plazas;

        public ENConcierto()
        {
            
        }

        public float getPrecio(){return precio;}
        public string getNombre(){return nombre;}
        public string getDescripcion(){return descripcion;}
        public int getPlazas(){return plazas;}
        public Lugar getLugar(){return lugar;}

        public void setPrecio(float precio) {
            this.precio = precio;
        }
        public void setNombre(string nombre) {
            this.nombre = nombre;
        }
        public void setDescripcion(string descripcion) {
            this.descripcion = descripcion;
        }
        public void setPlazas(int plazas) {
            this.plazas = plazas;
        }
        public void setLugar(Lugar lugar) {
            this.lugar = lugar;
        }
        public void setArtistas(List<ENArtista> artistas)
        {
            this.artistas = artistas;
        }

        public override string ToString()
        {
            return "";
        }

       
        public List<ENArtista> getArtistas(){
            return artistas;

        }
       

        public void addArtista(ENArtista artista)
        {
            artistas.Add(artista);
        }
        


    }
}
