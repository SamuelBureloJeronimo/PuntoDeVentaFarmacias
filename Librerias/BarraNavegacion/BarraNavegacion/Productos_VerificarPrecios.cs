using System;
using System.Windows.Forms;
using Empleados;

namespace BarraNavegacion
{
    public partial class Productos_VerificarPrecios : UserControl
    {
        private Usuario user { get; set; }
        public Productos_VerificarPrecios(Usuario user)
        {
            this.user = user;
            InitializeComponent();
        }
        private void Productos_VerificarPrecios_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }
    }
}
