using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ItxenaMusic
{
    public class ENUsuario
    {
  


        private string DNI;
        private string nombre;
        private string apellido;
        private string usuario;
        private string contrasenya;
        private string email;
        private bool activado;
        private List<ENCancion> pagadas;
        private List<ENAlbum> albumnes;
        private string tarjetaCredito;
        private string Paypal;
        private string cuentacorriente;
        private int metodoPago;

        public ENUsuario(string DNI, string nombre, string apellido, string usuario, string contrasenya, string email)
        {
            this.DNI = DNI;
            this.nombre = nombre;
            this.apellido = apellido;
            this.usuario = usuario;
            this.contrasenya = contrasenya;
            this.email = email;
            pagadas = new List<ENCancion>();
            albumnes = new List<ENAlbum>();
            activado = false;
            tarjetaCredito = "";
            Paypal = "";
            cuentacorriente = "";
            metodoPago = -1;
        }
        
        public string getDNI() { return DNI; }
        public string getApellido() { return apellido; }
        public string getUsuario() { return usuario; }
        public string getContrasenya() { return contrasenya; }
        public string getEmail() { return email; }
        public bool getActivado() { return activado; }
        public List<ENCancion> getPagadas() { return pagadas; }
        public List<ENAlbum> getAlbumnes() { return albumnes; }
        public string getTarjetaCredito() { return tarjetaCredito; }
        public string getPaypal() { return Paypal; }
        public string getCuentacorriente() { return cuentacorriente; }
        public int getMetodoPago() { return metodoPago; }

        public void addPagadas(ENCancion cancion)
        {
            pagadas.Add(cancion);
        }


    }
}

