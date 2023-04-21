using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Empleados
{
    public class Usuario : Empleado
    {
        //Variables de clase
        public string clvU { set; get; }
        public string pass { set; get; }
        public string tipo { set; get; }
        public MySqlConnection connection { set; get; }
        public Usuario(String clv, String pass, MySqlConnection connection)
        {
            this.clvU = clv;
            this.pass = pass;
            this.connection = connection;
        }
        public Boolean Login()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM users", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                string requestUser = row["user"].ToString();
                string requestPass = row["pass"].ToString();

                if (clvU.Equals(requestUser) && pass.Equals(requestPass))
                {
                    this.tipo = row["tipo"].ToString();
                    Console.WriteLine("¡Inicio de sesion correcto!");
                    requestEmp(requestUser, connection);
                    return true;
                }
            }
            return false;
        }
        public Boolean cambiarPassword(string oldPass, string newPass)
        {
            if (!oldPass.Equals(pass))
                return false;

            this.pass = newPass;
            return true;
        }
    }
}
