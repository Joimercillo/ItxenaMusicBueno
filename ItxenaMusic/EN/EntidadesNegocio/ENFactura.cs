using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ItxenaMusic
{
    public class ENFactura
    {
        public Fecha fecha;
        public ENUsuario usuario;
        

        public ENFactura()
        {
            // crea una factura
        }

        public Fecha getFecha(){
            return fecha;
        }

        public ENUsuario getUsuario()
        {
            return usuario;
        }

        public override string ToString()
        {
            return "";
        }
        
    }
}
