using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Empleados;

namespace PVF
{
    public partial class Login : Form
    {
        MySqlConnection connection;
        public Login()
        {
            InitializeComponent();
        }

        private void bttonClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que deseas salir?", "¡Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void bttonLogin_Click(object sender, EventArgs e)
        {
            string clv = txtBoxUser.Text;
            string pass = txtBoxPass.Text;

            Usuario user = new Usuario(clv, pass, connection);
            if(user.Login())
            {
                menuPrincipal menP = new menuPrincipal(user);
                user.connection = connection;
                menP.Show();
                this.Hide();
            }else 
                MessageBox.Show("Usuario/Contraseña incorrecta.\nVuelve a intentarlo.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string user = "root", pass = "";
            string connectionString = "server=localhost;port=3306;user id=" + user + ";password=" + pass + ";database=pvf";
            connection = new MySqlConnection(connectionString);
            try
            {
                //abre la conexion
                connection.Open();
                Console.WriteLine("Conexion establecida correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error conectar a la BD.", "Error", MessageBoxButtons.OK);
                Application.Exit();
                Console.WriteLine("Error conectar a la BD ->", ex);
            }
        }
    }
}
