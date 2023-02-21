using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Inventario;

namespace BarraNavegacion
{
    public partial class Productos: UserControl
    {
        TabControl tabControl;
        ArrayList ListMedicamentos;
        InventarioMed inv;
        public Productos(TabControl tabControl, InventarioMed inv)
        {
            this.tabControl = tabControl;
            this.ListMedicamentos = inv.Inventario;
            this.inv= inv;
            InitializeComponent();
        }
        private void btnAltaEdicion_Producto_Click(object sender, EventArgs e)
        {
            int pageIndex = tabControl.TabCount;
            for (int i = 0; i < tabControl.TabCount; i++)
            {
                if (tabControl.TabPages[i].Text.Equals("Alta/Edición"))
                {
                    tabControl.SelectedIndex = i;
                    //MessageBox.Show("La pagina ya existe.");
                    return;
                }

            }
            Productos_AltaEdicion pdAE = new Productos_AltaEdicion(tabControl, inv);

            TabPage tp = new TabPage();
            tp.Text = "Alta/Edición";
            tabControl.TabPages.Add(tp);

            tp.Controls.Add(pdAE.panelForm);
            pdAE.panelForm.Dock = DockStyle.Fill;
            pdAE.panelForm.Show();
            tabControl.SelectedIndex = pageIndex;
        }

        private void btnConsultIngre_Producto_Click(object sender, EventArgs e)
        {
            int pageIndex = tabControl.TabCount;
            for (int i = 0; i < tabControl.TabCount; i++)
            {
                if (tabControl.TabPages[i].Text.Equals("Consulta de Ingresos"))
                {
                    tabControl.SelectedIndex = i;
                    return;
                }
            }
            Productos_ConsultaIngresos CI = new Productos_ConsultaIngresos(tabControl);
            for (int i = 0; i < ListMedicamentos.Count; i++)
            {
                CI.bdMedic.Rows.Add();
                Medicamento md = (Medicamento)ListMedicamentos[i];

                double inversion = md.PrecioCompra * md.Cantidad;
                double ganancias = md.PrecioVenta * md.Cantidad;

                CI.bdMedic[0, i].Value = md.Codigo;
                CI.bdMedic[1, i].Value = md.Nombre;
                CI.bdMedic[2, i].Value = md.PrecioCompra.ToString();
                CI.bdMedic[3, i].Value = md.PrecioVenta.ToString();
                CI.bdMedic[4, i].Value = md.Tipo;
                CI.bdMedic[5, i].Value = md.Cantidad.ToString();
                CI.bdMedic[6, i].Value = (md.Iva * 100).ToString();
                CI.bdMedic[7, i].Value = md.Caducidad;
                CI.bdMedic[8, i].Value = inversion.ToString();
                CI.bdMedic[9, i].Value = ganancias.ToString();
            }
            TabPage pd = new TabPage();
            pd.Text = "Consulta de Ingresos";
            tabControl.TabPages.Add(pd);

            pd.Controls.Add(CI.panelForm);
            CI.panelForm.Dock = DockStyle.Fill;
            CI.panelForm.Show();
            tabControl.SelectedIndex = pageIndex;
        }
    }
}
