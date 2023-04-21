using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using Empleados;

namespace BarraNavegacion
{
    public partial class Productos_AltaEdicion: UserControl
    {
        private string FileName;
        private Usuario user { get; set; }
        public Productos_AltaEdicion(Usuario user)
        {
            this.user = user;
            InitializeComponent();
        }

        [Obsolete]
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
            double precioC = Convert.ToDouble(boxPrecioCompra.Text);
            double precioV = Convert.ToDouble(boxPrecioVenta.Text);
            string tipo = downBoxTipo.selectedValue;
            int cantidad = Int32.Parse(boxCantidad.Text);
            int iva = Int32.Parse(boxIva.Text);
            string fechCadu = fechCaducidad.Value.ToLongDateString();
            byte[] imageBytes = System.IO.File.ReadAllBytes(@FileName);

            MySqlCommand command = new MySqlCommand("INSERT INTO productos (clv, nombre, precioComp, precioVent, tipo, cantidad, ivaPorc, caducidad, img) VALUES (@value1, @value2, @value3, @value4, @value5, @value6, @value7, @value8, @value9)", user.connection);
            command.Parameters.AddWithValue("@value1", codigo);
            command.Parameters.AddWithValue("@value2", nombre);
            command.Parameters.AddWithValue("@value3", precioC);
            command.Parameters.AddWithValue("@value4", precioV);
            command.Parameters.AddWithValue("@value5", tipo);
            command.Parameters.AddWithValue("@value6", cantidad);
            command.Parameters.AddWithValue("@value7", iva);
            command.Parameters.AddWithValue("@value8", fechCadu);
            // Agregar parámetros al objeto MySqlCommand
            MySqlParameter param = new MySqlParameter("@image", MySqlDbType.LongBlob);
            param.Value = imageBytes;
            command.Parameters.Add("@value9", param);
            command.ExecuteNonQuery();

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
        // boxCodigo
        private void boxCodigo_Enter(object sender, EventArgs e)
        {
            if (boxCodigo.Text.Equals(""))
            {
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
        private void boxCantidad_Enter(object sender, EventArgs e)
        {
            if (boxCantidad.Text.Equals(""))
            {
                lblCantidad.Visible = true;
            }
        }
        private void boxCantidad_Leave(object sender, EventArgs e)
        {
            if (boxCantidad.Text.Replace(" ", "").Equals(""))
            {
                lblCantidad.Visible = false;
                boxCantidad.Text = string.Empty;
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
        private void btnEliminarIMG_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            FileName = string.Empty;
        }
    }
}
