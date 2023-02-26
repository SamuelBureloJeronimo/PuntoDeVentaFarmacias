using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    public class Departamento
    {
        private string clv, nmbr;
        public Boolean registrar(string clv, string nmbr)
        {
            this.clv = clv;
            this.nmbr = nmbr;
            return true;
        }
        public string Clv { get { return this.clv; } set { this.clv = value; } }
        public string Nmbr { get { return this.nmbr; } set { this.nmbr = value; } }
    }
}
