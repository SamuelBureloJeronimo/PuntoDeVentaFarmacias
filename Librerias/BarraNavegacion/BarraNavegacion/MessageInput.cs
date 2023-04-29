using Empleados;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace BarraNavegacion
{
    public partial class MessageInput : Form
    {
        String rfc;
        private Usuario user { get; set; }
        public MessageInput(Usuario user, String rfc)
        {
            this.user = user;
            this.rfc = rfc;
            InitializeComponent();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string pass = boxPass.Text;
            string passConfirm = boxPassConfirm.Text;
            int tipo = downBoxTipo.selectedIndex;
            String rol = downBoxTipo.selectedValue;
            String[,] insert = { { "user", "pass", "tipo" }, { rfc, pass, rol } };

            //Manda un mensaje de alerta que las contraseña o coinciden
            if (!pass.Equals(passConfirm))
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }
            //Manda un mensaje de alerta si no hay seleccionado
            if (tipo <= 0)
            {
                MessageBox.Show("Selecciona un Rol");
                return;
            }
            if(!user.connBD.compareDFT(insert, "users"))
            {
                MessageBox.Show("El usuario ya esta en el sistema.");
                return;
            }

            user.connBD.insertInto(insert, "users");

            MessageBox.Show("¡Usuario subido con exito!");
            this.Close();
        }
    }
}
