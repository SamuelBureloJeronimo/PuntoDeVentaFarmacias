using Bunifu.Framework.UI;
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
    public partial class Empleado : Form
    {
        private bool desplProduc = false;
        private bool desplClient = false;
        private bool desplVentas = false;
        public Empleado()
        {
            InitializeComponent();
            bttonMin.Visible = true;
            panelSubMenuProductos.Size = new System.Drawing.Size(294, 55);
            panelSubMenuVentas.Size = new System.Drawing.Size(294, 55);
            panelSubMenuClientes.Size = new System.Drawing.Size(294, 55);
        }

        private void bttonClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Estas seguro que deseas salir?","¡Alerta!",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bttonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            bttonMax.Visible= true;
            bttonMin.Visible= false;
        }

        private void bttonMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            bttonMax.Visible = false;
            bttonMin.Visible = true;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            if (desplProduc) {
                panelSubMenuProductos.Size = new System.Drawing.Size(294, 55);
                desplProduc = false;
            } else {
                panelSubMenuProductos.Size = new System.Drawing.Size(294, 220);
                desplProduc = true;
            }
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            if (desplVentas)
            {
                panelSubMenuVentas.Size = new System.Drawing.Size(294, 55);
                desplVentas = false;
            }
            else
            {
                panelSubMenuVentas.Size = new System.Drawing.Size(294, 165);
                desplVentas = true;
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (desplClient)
            {
                panelSubMenuClientes.Size = new System.Drawing.Size(294, 55);
                desplClient = false;
            }
            else
            {
                panelSubMenuClientes.Size = new System.Drawing.Size(294, 220);
                desplClient = true;
            }
        }
    }
}
