using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItxenaMusic
{
    public class ENCancion
    { 
           private int id;
           private string nombre;
           private string autor;
           private string album;
           private string genero;
           private string URL;
           private int puntuacion;
           private float precio;
           private int stock;
           private string descripcion;
           public static int IDES=0;
           public int descargas;

           public ENCancion(string nombre,string autor,string album, string genero,float precio,string URL)
           {
               IDES++;
               id = IDES;
               this.nombre = nombre;
               this.autor = autor;
               this.album = album;
               this.genero = genero;
               this.precio = precio;
               this.URL = URL;
               stock = 0;
               puntuacion = 0;
               descargas = 0;

           }

           
           public void AnyadirPuntuacion(int puntos){
               if (0 < puntos && puntos <= 5)
               {
                   puntuacion += puntos;
               }

           }

           public void descarga()
           {
               descargas++;
           }

           public float getPrecio()
           {
               return precio;
           }

            public string getNombre(){
                return nombre;
            }

            public void setNombre(string nombre)
            {
                this.nombre=nombre;
            }

            public string getAutor()
            {
                return autor;
            }

            public void setAutor(string autor)
            {
                this.autor = autor;
            }

            public string getAlbum()
            {
                return album;
            }

            public void setAlbum(string album)
            {
                this.album = album;
            }

            public string getGenero()
            {
                return genero;
            }

            public void setGenero(string genero)
            {
                this.genero = genero;
            }

            public string getURL()
            {
                return URL;
            }

            public void setURL(string URL)
            {
                this.URL = URL;
            }

            public int getPuntuacion()
            {
                return puntuacion;
            }

            public void setPuntuacion(int puntuacion)
            {
                this.puntuacion = puntuacion;
            }

            public int getStock()
            {
                return stock;
            }

            public void setStock(int stock)
            {
                this.stock = stock;
            }


            public string getDescripcion()
            {
                return descripcion;
            }

            public void setDescripcion(string descripcion)
            {
                this.descripcion = descripcion;
            }

            public int getDescargas()
            {
                return descargas;
            }

            public void setDescargas(int descargas)
            {
                this.descargas = descargas;
            }
           
            
        
    }
}
