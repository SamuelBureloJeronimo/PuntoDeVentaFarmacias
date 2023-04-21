using Empleados;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BarraNavegacion
{
    public partial class Empleados_DarAlta : UserControl
    {
        private Usuario user { get; set; }
        int nEst, nMun, nCol, nCalle, nDep;
        String FileName;
        public Empleados_DarAlta(Usuario user)
        {
            this.user = user;
            InitializeComponent();
            showEst();
        }

        public void showEst()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM estados", user.connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                downBoxEst.AddItem(row["nombre"].ToString());
            }
            command = new MySqlCommand("SELECT * FROM departamentos", user.connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                downBoxDep.AddItem(row["nombDep"].ToString());
            }
        }
        private void downBoxMun_onItemSelected(object sender, EventArgs e)
        {
            if (downBoxMun.selectedIndex == 0)
            {
                lblCol.Visible = false;
                downBoxCol.Visible = false;
                lblCalle.Visible = false;
                downBoxCalle.Visible = false;
                return;
            }
            downBoxCol.Clear();
            downBoxCol.AddItem("");
            lblCol.Visible = true;
            downBoxCol.Visible = true;
            MySqlCommand command = new MySqlCommand("SELECT * FROM municipios", user.connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                if (row["Nombre"].ToString().Equals(downBoxMun.selectedValue))
                {
                    nMun = Int32.Parse(row["clvMun"].ToString());
                    break;
                }
            }
            command = new MySqlCommand("SELECT * FROM colonias", user.connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                if (Int32.Parse(row["clvMun"].ToString()) == nMun)
                {
                    downBoxCol.AddItem(row["Nombre"].ToString());
                }
            }
        }

        private void downBoxCol_onItemSelected(object sender, EventArgs e)
        {
            if (downBoxCol.selectedIndex == 0)
            {
                lblCalle.Visible = false;
                downBoxCalle.Visible = false;
                return;
            }
            downBoxCalle.Clear();
            downBoxCalle.AddItem("");
            lblCalle.Visible = true;
            downBoxCalle.Visible = true;
            MySqlCommand command = new MySqlCommand("SELECT * FROM colonias", user.connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                if (row["Nombre"].ToString().Equals(downBoxCol.selectedValue))
                {
                    nCol = Int32.Parse(row["clvCol"].ToString());
                    break;
                }
            }
            command = new MySqlCommand("SELECT * FROM calles", user.connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                if (Int32.Parse(row["clvCol"].ToString()) == nCol)
                {
                    downBoxCalle.AddItem(row["Nombre"].ToString());
                }
            }
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

        private void downBoxDep_onItemSelected(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM departamentos", user.connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                if (row["nombDep"].ToString().Equals(downBoxDep.selectedValue))
                {
                    nDep = Int32.Parse(row["clvD"].ToString());
                    break;
                }
            }
        }

        private void downBoxCalle_onItemSelected(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM calles", user.connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                if (row["Nombre"].ToString().Equals(downBoxCalle.selectedValue))
                {
                    nCalle = Int32.Parse(row["clvCol"].ToString());
                    break;
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string rfc = boxRFC.Text;
            string nombre = boxName.Text;
            string apPat = boxApPat.Text;
            string apMat = boxApMat.Text;
            int clvCalle = nCalle;
            int clvDep = nDep;
            string horario = boxHorario.Text;
            string salario = boxSalario.Text;
            string fechContr = DateTime.Now.ToString();
            byte[] imageBytes = System.IO.File.ReadAllBytes(@FileName);

            MySqlCommand command = new MySqlCommand("INSERT INTO personas (rfc, nombre, app, apm, clvCalle) VALUES (@value1, @value2, @value3, @value4, @value5)", user.connection);
            command.Parameters.AddWithValue("@value1", rfc);
            command.Parameters.AddWithValue("@value2", nombre);
            command.Parameters.AddWithValue("@value3", apPat);
            command.Parameters.AddWithValue("@value4", apMat);
            command.Parameters.AddWithValue("@value5", clvCalle);
            command.ExecuteNonQuery();

            command = new MySqlCommand("INSERT INTO empleados (clvE, horario, fechContr, clvDep, salario) VALUES (@value1, @value2, @value3, @value4, @value5)", user.connection);
            command.Parameters.AddWithValue("@value1", rfc);
            command.Parameters.AddWithValue("@value2", horario);
            command.Parameters.AddWithValue("@value3", fechContr);
            command.Parameters.AddWithValue("@value4", clvDep);
            command.Parameters.AddWithValue("@value5", salario);
            command.ExecuteNonQuery();
            MessageBox.Show("Se registro correctamente.");
        }

        

        private void downBoxEst_onItemSelected(object sender, EventArgs e)
        {
            if (downBoxEst.selectedIndex == 0)
            {
                lblMun.Visible= false;
                downBoxMun.Visible = false;
                lblCol.Visible = false;
                downBoxCol.Visible = false;
                lblCalle.Visible = false;
                downBoxCalle.Visible = false;
                return;
            }
            downBoxMun.Clear();
            downBoxMun.AddItem("");
            lblMun.Visible = true;
            downBoxMun.Visible= true;
            MySqlCommand command = new MySqlCommand("SELECT * FROM estados", user.connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                if (row["Nombre"].ToString().Equals(downBoxEst.selectedValue))
                {
                    nEst = Int32.Parse(row["clvEst"].ToString());
                    break;
                }
            }
            command = new MySqlCommand("SELECT * FROM municipios", user.connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                if (Int32.Parse(row["clvEst"].ToString()) == nEst)
                {
                    downBoxMun.AddItem(row["Nombre"].ToString());
                }
            }
        }
    }
}
