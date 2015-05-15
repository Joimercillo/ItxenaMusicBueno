using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItxenaMusic
{
    public class Lugar
    {
        public int numero;
        public string ciudad;
        public string pais;
        public string codigopostal;
        public string direccion;

        public Lugar(string ciudad,string pais, string codigopostal, string direccion, int numero)
        {
            this.numero= numero;
            this.ciudad=ciudad;
            this.pais=pais;
            this.codigopostal = codigopostal;
            this.direccion = direccion;

        }

        public override string ToString()
        {
            return "";
        }



    }
}
