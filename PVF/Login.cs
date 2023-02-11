using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVF
{
    public partial class Login : Form
    {
        private Usuario user1;
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
            user1 = new Usuario(nam,pas,"Admin");

            if(!user1.Nombre.Equals("Samuel") & !user1.Clave.Equals("123"))
            {
                MessageBox.Show("Usuario/Contraseña incorrecta!");
                return;
            }
            menuPrincipal pri = new menuPrincipal(user1);
            this.Hide();
        }
    }
}
