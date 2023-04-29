using System;
using System.Windows.Forms;

namespace BarraNavegacion
{
    public partial class MenusItem: UserControl
    {
        private Productos_AltaEdicion pdAE;
        private Productos_ConsultaIngresos CI;
        private Productos_VerificarPrecios VP;
        private Empleados_DarAlta darAltaEmpl;
        private Administracion_CreateNewUser AD_CNU;

        private Panel pn;

        public MenusItem(ContextBoundObject context)
        {
            this.pn= pn;
            InitializeComponent();
        }
        // ------------------------------------------------------------------------------------------------------------------------------ //
        //                                                  SubMenu -- Producto
        private void btnAltaEdicion_Producto_Click(object sender, EventArgs e) // -- btnAltaEdicion_Producto_Click
        {
            pn.Controls.Clear();
            pdAE.Dock = DockStyle.Fill;
            pn.Controls.Add(pdAE);
        }
        private void btnConsultIngre_Producto_Click(object sender, EventArgs e) // -- btnConsultIngre_Producto_Click
        {
            pn.Controls.Clear();
            CI.Dock = DockStyle.Fill;
            CI.loadTable();
            pn.Controls.Add(CI);
        }

        private void btnVerifPrice_Producto_Click(object sender, EventArgs e)
        {
            pn.Controls.Clear();
            VP.Dock = DockStyle.Fill;
            pn.Controls.Add(VP);
        }

        // ------------------------------------------------------------------------------------------------------------------------------ //
        //                                                  SubMenu -- Empleado

        // ------------------------------------------------------------------------------------------------------------------------------ //
        //                                                  SubMenu -- Cliente
        private void btnDarAlta_Click_1(object sender, EventArgs e)
        {
            pn.Controls.Clear();
            darAltaEmpl.Dock = DockStyle.Fill;
            pn.Controls.Add(darAltaEmpl);
        }
        // ------------------------------------------------------------------------------------------------------------------------------ //
        //                                                  SubMenu -- Administración
        private void CreateNewUser_Click(object sender, EventArgs e)
        {
            pn.Controls.Clear(); //Limpia la coleccion de controles que tiene el Panel
            AD_CNU.Dock = DockStyle.Fill; // Adapta el tamaño del userControl al Panel
            pn.Controls.Add(AD_CNU); //Agrega el UserControl a la collecion de controles del panel
        }        
    }
}
