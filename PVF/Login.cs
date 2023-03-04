using System;
using System.Windows.Forms;
using ControlUsuario;

namespace PVF
{
    public partial class Login : Form
    {
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
            string nam = txtBoxUser.Text;
            string pas = txtBoxPass.Text;
            Usuario user1 = new Usuario(nam, pas, "Admin");
            IniciarSesion(user1);
        }
        public void IniciarSesion(Usuario usu)
        {
            if (!usu.Nombre.Equals("") & !usu.Clave.Equals(""))
            {
                MessageBox.Show("Usuario/Contraseña incorrecta!");
                return;
            }
            menuPrincipal pri = new menuPrincipal(usu);
            this.Hide();
        }
    }
}
