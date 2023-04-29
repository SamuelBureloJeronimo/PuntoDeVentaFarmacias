using MySql.Data.MySqlClient;
using PVF.Models;
using System.Data;
using System;

namespace PVF.Controllers
{
    public class PersonaController : PersonaModel
    {

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
