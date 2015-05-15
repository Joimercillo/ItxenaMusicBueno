using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ItxenaMusic
{
    class CADArtista
    {
        
        ArrayList lista = new ArrayList();
        string s = "data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\Database1.mdf;User Instance=true";

        public CADArtista()
        {

        }

        public void crearArtista()
        {
            //crea una Artista;
        }

        public ItxenaMusic.ENArtista dameArtista(string id)
        {
            //devuelve un Artista
            return null;
        }

        public void creaArtista()
        {
            //Crea un Artista
        }

        public void BorraArtista()
        {
            //Borra un Artista
        }

        public void actualizaArtista()
        {
            //Actualiza un Artista
        }

        
        public ArrayList mostrarArtistas()
        {
            SqlConnection c = new SqlConnection(s);
            c.Open();
            SqlCommand com = new SqlCommand("Select * from artista", c);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(dr["nombre"].ToString());
            }
            dr.Close();
            c.Close();
            return lista;
        }
        
    }
}
