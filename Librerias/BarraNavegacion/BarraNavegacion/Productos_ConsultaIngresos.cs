using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarraNavegacion
{
    public partial class Productos_ConsultaIngresos : UserControl
    {
        private TabControl tabControl;
        public Productos_ConsultaIngresos(TabControl tabControl)
        {
            this.tabControl = tabControl;
            InitializeComponent();
            bdMedic.Columns[8].DefaultCellStyle.ForeColor = Color.Red;
            bdMedic.Columns[9].DefaultCellStyle.ForeColor = Color.Green;
        }

        private void bttonClose_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tabControl.TabPages[tabControl.SelectedIndex]);
        }
    }
}
