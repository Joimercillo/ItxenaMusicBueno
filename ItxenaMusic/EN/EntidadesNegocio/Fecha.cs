using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItxenaMusic
{
    public class Fecha
    {
        int dia;
        int mes;
        int anyo;

        public Fecha(int dia,int mes,int anyo)
        {
            this.dia = dia;
            this.mes = mes;
            this.anyo = anyo;
        }

        public string ToSTring()
        {
            return (dia.ToString()+"/"+mes.ToString()+"/"+anyo.ToString());
        }


    }
}
