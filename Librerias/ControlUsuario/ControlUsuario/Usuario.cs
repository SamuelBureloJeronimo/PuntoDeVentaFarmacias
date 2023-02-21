using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlUsuario
{
    public class Usuario
    {
        //Variables de clase
        private string nombre, clave, tipo;
        //Constructor
        public Usuario(string nombre, string clave, string tipo)
        {
            this.nombre = nombre;
            this.clave = clave;
            this.tipo = tipo;
        }
        public Boolean cambiarPassword(string beforePass, string newPass)
        {
            if (!beforePass.Equals(clave))
                return false;

            this.clave = newPass;
            return true;
        }
        //Getters
        public string Nombre { get { return nombre; } }
        public string Clave { get { return clave; } }
        public string Tipo { get { return tipo; } }
    }
}
