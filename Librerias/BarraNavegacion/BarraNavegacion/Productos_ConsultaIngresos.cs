using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using Inventario;

namespace BarraNavegacion
{
    public partial class Productos_ConsultaIngresos : UserControl
    {
        private TabControl tabControl;
        private ArrayList ListMedicamentos;
        public Productos_ConsultaIngresos(TabControl tabControl)
        {
            this.tabControl = tabControl;
            InitializeComponent();
        }
        public ArrayList list{ get { return this.ListMedicamentos; } set { this.ListMedicamentos = value; } }
        public void loadTable()
        {
            bdMedic.Rows.Clear();
            bdMedic.Columns[8].DefaultCellStyle.ForeColor = Color.Red;
            bdMedic.Columns[9].DefaultCellStyle.ForeColor = Color.Green;
            for (int i = 0; i < ListMedicamentos.Count; i++)
            {
                bdMedic.Rows.Add();
                Medicamento md = (Medicamento)ListMedicamentos[i];

                double inversion = md.PrecioCompra * md.Cantidad;
                double ganancias = md.PrecioVenta * md.Cantidad;

                bdMedic[0, i].Value = md.Codigo;
                bdMedic[1, i].Value = md.Nombre;
                bdMedic[2, i].Value = md.PrecioCompra.ToString();
                bdMedic[3, i].Value = md.PrecioVenta.ToString();
                bdMedic[4, i].Value = md.Tipo;
                bdMedic[5, i].Value = md.Cantidad.ToString();
                bdMedic[6, i].Value = (md.Iva * 100).ToString();
                bdMedic[7, i].Value = md.Caducidad;
                bdMedic[8, i].Value = inversion.ToString();
                bdMedic[9, i].Value = ganancias.ToString();
            }
        }
        private void bttonClose_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tabControl.TabPages[tabControl.SelectedIndex]);
            //tabControl.TabPages.Clear();
        }
    }
}
