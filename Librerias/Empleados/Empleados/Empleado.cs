using MySql.Data.MySqlClient;
using System;
using System.Data;

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
        private string clvE, horario, fechContr;
        private Departamento dep;
        private double salario;
        public Boolean registrar
            (
            //Atributos de Persona
            string RFC,     string nmbr,    string apPat,   string apMat,   string fchNc,   string crr,     string estCivil,
            int Estad,      int mun,        int cln,        int calle,      int CP,         int telf,
            //Atributos de Empleado
            string numE,    string hrar,    string fchCnt, string clvDep,  double salario
            )
        {

            return true;
        }
        public void requestEmp(String clvEmp, MySqlConnection connection)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM empleados", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                string requestClvE = row["clvE"].ToString();

                if (clvEmp.Equals(requestClvE))
                {
                    this.clvE   = requestClvE;
                    horario     = row["horario"].ToString();
                    fechContr   = row["fechContr"].ToString();
                    salario     = Double.Parse(row["salario"].ToString());
                    Console.WriteLine("¡Empleado encontrado!");
                    dep = new Departamento();
                    dep.requestDep(row["clvDep"].ToString(), connection);
                    requestPersona(clvEmp, connection);
                    return;
                }
            }
            Console.WriteLine("No se encontro Empleado con la clave "+clvEmp);
        }
    }
}
