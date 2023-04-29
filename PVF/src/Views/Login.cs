using System;
using System.Windows.Forms;
using PVF.Controllers;
using PVF.Libraries;

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
            string clv = txtBoxUser.Text;
            string pass = txtBoxPass.Text;

            UserController uc = new UserController();
            if (!uc.login(clv, pass)){
                MessageBox.Show("Usuario/Contraseña incorrecta.\nVuelve a intentarlo.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            
            // Si todo sale bien se ejecuta estas instrucciones
            menuPrincipal menP = new menuPrincipal();
            menP.Show();
            this.Hide();
        }
    }
}
