using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PVF.Properties;
using WindowsFormsControlLibrary1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PVF
{
    public partial class AltaProductos : Form
    {
        public string FileName;
        public AltaProductos()
        {
            InitializeComponent();
        }
        
        private void bttonClose_Click(object sender, EventArgs e)
        {
            panelForm.Hide();
        }
        // boxCodigo
        private void boxCodigo_Enter(object sender, EventArgs e)
        {
            if (boxCodigo.Text.Equals("")) {
                lblCodigo.Visible = true;
            }
        }
        private void boxCodigo_Leave(object sender, EventArgs e)
        {
            if (boxCodigo.Text.Replace(" ", "").Equals(""))
            {
                lblCodigo.Visible = false;
                boxCodigo.Text = string.Empty;
            }
        }
        // boxName
        private void boxName_Enter(object sender, EventArgs e)
        {
            if (boxName.Text.Equals(""))
            {
                lblName.Visible = true;
            }
        }
        private void boxName_Leave(object sender, EventArgs e)
        {
            if (boxName.Text.Replace(" ", "").Equals(""))
            {
                lblName.Visible = false;
                boxName.Text = string.Empty;
            }
        }
        // boxCompra
        private void boxPrecioCompra_Enter(object sender, EventArgs e)
        {
            if (boxPrecioCompra.Text.Equals(""))
            {
                lblPrecioCompra.Visible = true;
            }
        }
        private void boxPrecioCompra_Leave(object sender, EventArgs e)
        {
            if (boxPrecioCompra.Text.Replace(" ", "").Equals(""))
            {
                lblPrecioCompra.Visible = false;
                boxPrecioCompra.Text = string.Empty;
            }
        }
        // boxVenta
        private void boxPrecioVenta_Enter(object sender, EventArgs e)
        {
            if (boxPrecioVenta.Text.Equals(""))
            {
                lblPrecioVenta.Visible = true;
            }
        }
        private void boxPrecioVenta_Leave(object sender, EventArgs e)
        {
            if (boxPrecioVenta.Text.Replace(" ", "").Equals(""))
            {
                lblPrecioVenta.Visible = false;
                boxPrecioVenta.Text = string.Empty;
            }
        }
        // boxLote
        private void boxLote_Enter(object sender, EventArgs e)
        {
            if (boxLote.Text.Equals(""))
            {
                lblLote.Visible = true;
            }
        }
        private void boxLote_Leave(object sender, EventArgs e)
        {
            if (boxLote.Text.Replace(" ", "").Equals(""))
            {
                lblLote.Visible = false;
                boxLote.Text = string.Empty;
            }
        }
        // boxIVA
        private void boxIva_Enter(object sender, EventArgs e)
        {
            if (boxIva.Text.Equals(""))
            {
                lblIVA.Visible = true;
            }
        }
        private void boxIva_Leave(object sender, EventArgs e)
        {
            if (boxIva.Text.Replace(" ", "").Equals(""))
            {
                lblIVA.Visible = false;
                boxIva.Text = string.Empty;
            }
        }
        private void btnLimpiarBoxs_Click(object sender, EventArgs e)
        {
            boxCodigo.Text = string.Empty;
            boxName.Text = string.Empty;
            boxPrecioCompra.Text = string.Empty;
            boxPrecioVenta.Text = string.Empty;
            boxLote.Text = string.Empty;
            boxIva.Text = string.Empty;

            lblCodigo.Visible = false;
            lblName.Visible = false;
            lblPrecioCompra.Visible = false;
            lblPrecioVenta.Visible= false;
            lblLote.Visible = false;
            lblIVA.Visible = false;

            downBoxTipo.selectedIndex = 0;
        }
        private void btnAgregarIMG_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Imagenes jpg (*.jpg)|*.jpg|Imagenes jpeg (*.jpeg)|*.jpeg|Imagenes png (*.png)|*.png";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(FileName);
            }
        }

        private void btnEliminarIMG_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void boxPrecioCompra_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void downBoxTipo_Enter(object sender, EventArgs e)
        {
            //downBoxTipo.ActiveControl= this;
        }
    }
}
