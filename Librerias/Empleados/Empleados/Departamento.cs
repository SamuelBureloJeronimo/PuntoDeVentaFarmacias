using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    public class Departamento
    {
        public string clvDep { get; set; }
        public string nameDep { get; set; }
        public Boolean registrar(string clv, string nmbr)
        {
            
            return true;
        }
        public void requestDep(String clvDep, MySqlConnection connection)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM departamentos", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                string requestClvDep = row["clvD"].ToString();

                if (clvDep.Equals(requestClvDep))
                {
                    this.clvDep = requestClvDep;
                    this.nameDep = row["nombDep"].ToString();
                    Console.WriteLine("¡Departamento encontrado!");
                    return;
                }
            }
            Console.WriteLine("No se encontro Departamento con la clave " + clvDep);
        }
    }
}
