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
    public partial class ConsultaDeIngresos : Form
    {
        public ConsultaDeIngresos()
        {
            InitializeComponent();
            bdMedic.Columns[8].DefaultCellStyle.ForeColor = Color.Red;
            bdMedic.Columns[9].DefaultCellStyle.ForeColor = Color.Green;
        }
    }
}
