using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    public class Persona
    {
        /*
         * - RFC // Registro Federal del Contribuyente
         * - nmbr // Nombre
         * - apPat // Apellido Paterno
         * - apMat // Apellido Materno
         * - fchNc // Fecha de Nacimiento
         * - Estado // Numero del Estado
         * - mun // Numero del Municipio
         * - cln // Numero de la Colonia
         * - calle // Numero de la calle
         * - CP // Codigo Postal
         * - telf // Telefono
         * - correo // Correo electronico
         */
        protected string RFC, nmbr, apPat, apMat, fchNc, crr;
        protected int Estad, mun, cln, calle, CP, telf;
        // Setters y Getters
        public string rfc { get { return this.RFC; } set { this.RFC = value; } }
        public string nom { get { return this.nmbr; } set { this.nmbr = value; } }
        public string apP { get { return this.apPat; } set { this.apPat = value; } }
        public string apM { get { return this.apMat; } set { this.apMat = value; } }
        public string fechNac { get { return this.fchNc; } set { this.fchNc = value; } }
        public string correo { get { return this.crr; } set { this.crr = value; } }
        public int NoEstad { get { return this.Estad; } set { this.Estad = value; } }
        public int NoMun { get { return this.mun; } set { this.mun = value; } }
        public int NoCln { get { return this.cln; } set { this.cln = value; } }
        public int NoCalle { get { return this.cln; } set { this.cln = value; } }
        public int NoCP { get { return this.CP; } set { this.CP = value; } }
        public int NoTel { get { return this.telf; } set { this.telf = value; } }
    }
}
