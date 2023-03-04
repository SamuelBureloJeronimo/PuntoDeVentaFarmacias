using System;
using System.Windows.Forms;
using System.Collections;
using Inventario;

namespace BarraNavegacion
{
    public partial class MenusItem: UserControl
    {
        private TabControl tabControl;
        private InventarioMed inv;

        
        Productos_ConsultaIngresos CI;

        public MenusItem(TabControl tabControl, InventarioMed inv)
        {
            this.tabControl = tabControl;
            this.inv= inv;
            InitializeComponent();
            CI = new Productos_ConsultaIngresos(tabControl);
        }
        private Boolean searchTP(string nP)
        {
            for (int i = 0; i < tabControl.TabCount; i++)
            {
                if (tabControl.TabPages[i].Text.Equals(nP))
                {
                    tabControl.SelectedIndex = i;
                    //MessageBox.Show("La pagina ya existe.");
                    return true;
                }
            }
            return false;
        }
        private void showPanel(string nP, Panel pF)
        {
            TabPage tp = new TabPage();
            tp.Text = nP;
            tabControl.TabPages.Add(new TabPage());

            tp.Controls.Add(pF);
            pF.Dock = DockStyle.Fill;
            pF.Show();
            tabControl.SelectedIndex = tabControl.TabCount-1;
        }
        // ------------------------------------------------------------------------------------------------------------------------------ //
        //                                                  SubMenu -- Producto
        private void btnAltaEdicion_Producto_Click(object sender, EventArgs e) // -- btnAltaEdicion_Producto_Click
        {
            if (searchTP("Registrar"))
                return;
            Productos_AltaEdicion pdAE = new Productos_AltaEdicion(tabControl, inv);
            showPanel("Registrar", pdAE.panelForm);
        }
        private void btnConsultIngre_Producto_Click(object sender, EventArgs e) // -- btnConsultIngre_Producto_Click
        {
            if (searchTP("Consulta de Ingresos"))
                return;
            showPanel("Consulta de Ingresos", CI.panelForm);
            CI.list = inv.Inventario;
            CI.loadTable();
        }
        // ------------------------------------------------------------------------------------------------------------------------------ //
        //                                                  SubMenu -- Cliente
    }
}
