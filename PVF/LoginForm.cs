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
    public partial class LoginForm : Form
    {
        public LoginForm()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttonLogin_Click(object sender, EventArgs e)
        {
            string nam = txtBoxUser.Text;
            string pas = txtBoxPass.Text;
            if(!nam.Equals("Samuel") & !pas.Equals("123"))
            {
                MessageBox.Show("Usuario/Contraseña incorrecta!");
                return;
            }
            menuPrincipal pri = new menuPrincipal(nam,pas,"Admin");
            this.Hide();
        }
    }
}
