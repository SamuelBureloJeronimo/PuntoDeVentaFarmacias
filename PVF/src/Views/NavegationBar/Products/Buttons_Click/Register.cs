using Microsoft.VisualBasic.ApplicationServices;
using PVF.Libraries;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PVF.src.Views.NavegationBar.Products.Buttons
{
    public partial class Register : UserControl, IDisposable
    {
        private String FileName;
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (boxCodigo.Text.Equals("") || boxName.Text.Equals("") || boxPrecioCompra.Text.Equals("") || boxPrecioVenta.Text.Equals(""))
            {
                MessageBox.Show("Debes rellenar todos los campos.");
                return;
            }
            if (downBoxTipo.selectedIndex == 0 || boxCantidad.Text.Equals("") || boxIva.Text.Equals("") || FileName == null)
            {
                MessageBox.Show("Debes rellenar todos los campos.");
                return;
            }
            string codigo = boxCodigo.Text;
            string nombre = boxName.Text;
            double precioC = double.Parse(boxPrecioCompra.Text);
            double precioV = double.Parse(boxPrecioVenta.Text);
            string tipo = downBoxTipo.selectedValue;
            int cantidad = Int32.Parse(boxCantidad.Text);
            int iva = Int32.Parse(boxIva.Text);
            string fechCadu = fechCaducidad.Value.ToLongDateString();
            byte[] imageBytes = System.IO.File.ReadAllBytes(@FileName);

            object[,] insert = { { "clv", "nombre", "precioComp", "precioVent", "tipo", "cantidad", "ivaPorc", "caducidad", "img" },
                              { codigo, nombre, precioC, precioV, tipo, cantidad, iva, fechCadu, imageBytes } };
            DB_Connector db = new DB_Connector();
            db.insertInto(insert, "productos");

            MessageBox.Show("Se registro correctamente.");
            boxCodigo.Text = string.Empty;
            boxName.Text = string.Empty;
            boxPrecioCompra.Text = string.Empty;
            boxPrecioVenta.Text = string.Empty;
            boxCantidad.Text = string.Empty;
            boxIva.Text = string.Empty;

            lblCodigo.Visible = false;
            lblName.Visible = false;
            lblPrecioCompra.Visible = false;
            lblPrecioVenta.Visible = false;
            lblCantidad.Visible = false;
            lblIVA.Visible = false;

            downBoxTipo.selectedIndex = 0;
            pictureBox1.Image = null;
            FileName = string.Empty;
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

        private void btnLimpiarBoxs_Click(object sender, EventArgs e)
        {
            boxCodigo.Text = string.Empty;
            boxName.Text = string.Empty;
            boxPrecioCompra.Text = string.Empty;
            boxPrecioVenta.Text = string.Empty;
            boxCantidad.Text = string.Empty;
            boxIva.Text = string.Empty;

            lblCodigo.Visible = false;
            lblName.Visible = false;
            lblPrecioCompra.Visible = false;
            lblPrecioVenta.Visible = false;
            lblCantidad.Visible = false;
            lblIVA.Visible = false;

            pictureBox1.Image = null;
            FileName = string.Empty;

            downBoxTipo.selectedIndex = 0;
        }
    }
}
