using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    public class Empleado : Persona
    {
        /*
         * - numE
         * - salario
         * - horario
         * - fechContr
         * - est // Estatus actual ejemp. Activo, Suspendido, Vacaciones y Inactivo
         * - clvDep
         */
        private string numE, horario, fechContr, est;
        private Departamento dep;
        private double salario;
        public Boolean registrar
            (
            //Atributos de Persona
            string RFC,     string nmbr,    string apPat,   string apMat,   string fchNc,   string crr,     string est,
            int Estad,      int mun,        int cln,        int calle,      int CP,         int telf,
            //Atributos de Empleado
            string numE,    string hrar,    string fchCnt,  string st, Departamento clvDep,  double salario
            )
        {
            //Atributos de Persona
            this.RFC = RFC;
            this.nmbr = nmbr;
            this.apPat = apPat;
            this.apMat = apMat;
            this.fchNc = fchNc;
            this.crr = crr;
            this.est = est;
            this.Estad = Estad;
            this.mun = mun;
            this.cln = cln;
            this.calle = calle;
            this.CP = CP;
            this.telf = telf;
            //Atributos de Empleado
            this.numE = numE;
            this.horario = hrar;
            this.fechContr = fchCnt;
            this.est = st;
            this.dep = clvDep;
            this.salario= salario;
            return true;
        }
    }
}
