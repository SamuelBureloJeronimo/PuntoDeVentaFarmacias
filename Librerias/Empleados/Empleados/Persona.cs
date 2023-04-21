using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
        public string RFC { get; set; }
        public string nmbrP { get; set; }
        public string apPat { get; set; }
        public string apMat { get; set; }
        public string fchNc { get; set; }
        public string crr { get; set; }
        public string estCivil { get; set; }
        public int Estad { get; set; }
        public int mun { get; set; }
        public int cln { get; set; }
        public int calle { get; set; }
        public int CP { get; set; }
        public int telf { get; set; }
        public Boolean registrarPer(MySqlConnection connection)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO mytable (rfc, nombre, app, apm) VALUES (@value1, @value2, @value3, @value4)", connection);
            command.Parameters.AddWithValue("@value1", "valor1");
            command.Parameters.AddWithValue("@value2", 123);
            command.Parameters.AddWithValue("@value3", DateTime.Now);
            command.Parameters.AddWithValue("@value4", DateTime.Now);
            command.ExecuteNonQuery();
            return true;
        }
        public void requestPersona(String clvPer, MySqlConnection connection)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM personas", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                string requestClvDPer = row["rfc"].ToString();

                if (clvPer.Equals(requestClvDPer))
                {
                    this.RFC = requestClvDPer;
                    this.nmbrP = row["nombre"].ToString();
                    Console.WriteLine("¡Persona encontrada!");
                    return;
                }
            }
            Console.WriteLine("No se encontro ninguna persona con RFC: " + clvPer);
        }
    }
}
