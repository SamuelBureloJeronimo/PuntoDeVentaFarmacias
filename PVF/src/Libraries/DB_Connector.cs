using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace PVF.Libraries
{
    public class DB_Connector
    {
        private MySqlConnection connection;

        private String server= "localhost";
        private String port= "3306";
        private String userID = "root";
        private String password = "";
        private String nameDB = "pvf";

        /// <summary>
        /// Metodo que apertura la conexión a la base de datos con los datos de la clase.
        /// </summary>
        /// <returns>Retorna un Boolean, si se establece la conexion correctamente o no.</returns>
        public Boolean openConnection()
        {
            string connectionString = "server=" + server + ";port=" + port
                                     + ";user id=" + userID + ";password=" + password
                                     + ";database=" + nameDB;

            connection = new MySqlConnection(connectionString);
            try
            {
                //abre la conexion
                connection.Open();
                Console.WriteLine("Conexion establecida correctamente.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error conectar a la BD ->", ex);
            }
            return false;
        }

        public void closeConnection()
        {
            try
            {
                //close the connection
                connection.Close();
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cerrar la Base de Datos ->", ex);
            }

        }

        /// <summary>
        /// Este metodo hace una consulta SQL solamente a una tabla, ya que retorna un DataSet.
        /// </summary>
        /// <param nameTable="param1">Nombre de la tabla a consultar</param>
        /// <returns>Retorna el objeto DataSet con los datos consultados.</returns>
        public DataSet requestTable(String nameTable)
        {
            openConnection();
            //Obtengo la consulta con un objeto de la clase MySQL Client
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM " + nameTable, connection);
            DataSet table = new DataSet(); //Creo un DataSet para asignarle la tabla consultada
            adapter.Fill(table); //Linea para darle la tabla obtenida

            //Libera los recursos no administrativos
            adapter.Dispose();
            closeConnection();

            return table;
        }
        /// <summary>
        /// Compara datos especificos de la Table a consultar.<br/><br/>
        /// Estructura del arreglo:<br/>
        /// String[,] compare = { { nomeColum1, nomeColum2, ... }, 
        ///                       { compareColum1, compareColum2, ... } }<br/>
        /// *La 1ra fila es para el nombre de las columnas*<br/>
        /// *La segunda es para el dato a comparar con el nombre de la columa correspondiente*<br/><br/>
        /// -- Por ejemplo:  { "nombreUser", "apellido", ... }, { "Samuel", "Burelos" }<br/>
        /// Puede comparar tantos datos como guste pero solo debe tener 2 filas.<br/>
        /// </summary>
        /// <param compare="compare">Arreglo bidimencional con los datos a comparar</param>
        /// <param nameTable="nameTable">Nombre de la tabla a consultar</param>
        /// <returns>Retorna un Boolean solo si todas las comparaciones coincidieron.</returns>
        public Boolean compareDFT(String[,] compare, String nameTable)
        {
            if (compare.GetLength(0) > 2)
            {
                Console.WriteLine("El arreglo solo llevar 2 filas de la siguiente forma: ");
                Console.WriteLine("String[,] compare = { { nomeColum1, nomeColum2, ... }, ");
                Console.WriteLine("                      { compareColum1, compareColum2, ... } }");
                return false;
            }
            int d = 0; //Lleva el conteo de los campos encontrados
            DataSet table = requestTable(nameTable);

            foreach (DataRow row in table.Tables[0].Rows)
            {
                //Recorro todas las columnas del arreglo [compare]
                for (int col = 0; col < compare.GetLength(1); col++)
                {
                    //Consulta el valor del dato de la columna por el nombre de columna
                    //El nombre de la columna esta dado en arreglo
                    string request = row[compare[0, col]].ToString();
                    //Obtiene el valor a comparar porporcionado por el Arreglo
                    string comp = compare[1, col];
                    //Compara ambos datos con los obtenido: la consulta y el valor del arreglo
                    if (request.Equals(comp))
                        d++;
                    //Si al final del arreglo todos los datos coincidieron retorna verdadero
                    if (d == compare.GetLength(0))
                        return true;
                }
                d = 0;
            }
            return false;
        }

        /// <summary>
        /// Compara datos especificos de la Table a consultar.<br/><br/>
        /// Estructura del arreglo:<br/>
        /// String[,] compare = { { nomeColum1, nomeColum2, ... }, 
        ///                       { compareColum1, compareColum2, ... } }<br/>
        /// *La 1ra fila es para el nombre de las columnas*<br/>
        /// *La segunda es para el dato a comparar con el nombre de la columa correspondiente*<br/><br/>
        /// -- Por ejemplo:  { "nombreUser", "apellido", ... }, { "Samuel", "Burelos" }<br/>
        /// Puede comparar tantos datos como guste pero solo debe tener 2 filas.<br/>
        /// </summary>
        /// <param compare="compare">Arreglo bidimencional con los datos a comparar</param>
        /// <param nameTable="nameTable">Nombre de la tabla a consultar</param>
        /// <returns>Retorna un Boolean solo si todas las comparaciones coincidieron.</returns>
        public Boolean insertInto(Object[,] dataInsert, String nameTable)
        {
            if (dataInsert.GetLength(0) > 2)
            {
                Console.WriteLine("El arreglo solo llevar 2 filas de la siguiente forma: ");
                Console.WriteLine("String[,] dataInsert = { { nomeColum1, nomeColum2, ... }, ");
                Console.WriteLine("                      { insertColum1, insertColum2, ... } }");
                return false;
            }
            string textCommand = "INSERT INTO " + nameTable + " (";

            /************************************************************************/
            //Agrega todos NOMBRES de las columnas de la tabla
            for (int col = 0; col < dataInsert.GetLength(1); col++)
            {
                if ((col + 1) >= dataInsert.GetLength(1))
                {
                    //El nombre de la columna esta dado en arreglo
                    string request2 = dataInsert[0, col].ToString();
                    textCommand += request2 + ") VALUES (";
                    break;
                }
                //El nombre de la columna esta dado en arreglo
                string request = dataInsert[0, col].ToString();
                textCommand += request + ", ";
            }
            /************************************************************************/
            //Agregar todos los @values necesarios
            for (int col = 0; col < dataInsert.GetLength(1); col++)
            {
                if ((col + 1) >= dataInsert.GetLength(1))
                {
                    textCommand += "@value" + (col + 1) + ")";
                    break;
                }
                textCommand += "@value" + (col + 1) + ", ";
            }
            /************************************************************************/
            openConnection();
            MySqlCommand command = new MySqlCommand(textCommand, connection);
            //Este for se utiliza para asigarle valor a todos los @values
            for (int col = 0; col < dataInsert.GetLength(1); col++)
            {
                if (dataInsert[1, col].GetType() == typeof(string))
                {
                    string dat = dataInsert[1, col].ToString();
                    Console.WriteLine("@value" + (col + 1) + "" + dat);
                    command.Parameters.AddWithValue("@value" + (col + 1), dat);
                }
                else if (dataInsert[1, col].GetType() == typeof(int))
                {
                    int dat = Int32.Parse(dataInsert[1, col].ToString());
                    Console.WriteLine("@value" + (col + 1) + "" + dat);
                    command.Parameters.AddWithValue("@value" + (col + 1), dat);
                }
                else if (dataInsert[1, col].GetType() == typeof(double))
                {
                    double dat = Convert.ToDouble(dataInsert[1, col].ToString());
                    Console.WriteLine("@value" + (col + 1) + "" + dat);
                    command.Parameters.AddWithValue("@value" + (col + 1), dat);
                }
                else if (dataInsert[1, col].GetType() == typeof(byte[]))
                {
                    byte[] dat = System.Text.Encoding.UTF8.GetBytes(dataInsert[1, col].ToString());
                    // Agregar parámetros al objeto MySqlCommand
                    MySqlParameter param = new MySqlParameter("@image", MySqlDbType.LongBlob);
                    param.Value = dat;
                    command.Parameters.AddWithValue("@value" + (col + 1), param);
                }
            }
            Console.WriteLine(textCommand);
            command.ExecuteNonQuery();
            closeConnection();
            return false;
        }
    }
}
