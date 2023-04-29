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
            DataSet table = user.connBD.requestTable("estados");
            foreach (DataRow row in table.Tables[0].Rows)
            {
                downBoxEst.AddItem(row["nombre"].ToString());
            }
            table = user.connBD.requestTable("departamentos");
            foreach (DataRow row in table.Tables[0].Rows)
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
            DataSet table = user.connBD.requestTable("municipios");
            foreach (DataRow row in table.Tables[0].Rows)
            {
                if (row["Nombre"].ToString().Equals(downBoxMun.selectedValue))
                {
                    nMun = Int32.Parse(row["clvMun"].ToString());
                    break;
                }
            }
            table = user.connBD.requestTable("colonias");
            foreach (DataRow row in table.Tables[0].Rows)
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
            DataSet table = user.connBD.requestTable("colonias");
            foreach (DataRow row in table.Tables[0].Rows)
            {
                if (row["Nombre"].ToString().Equals(downBoxCol.selectedValue))
                {
                    nCol = Int32.Parse(row["clvCol"].ToString());
                    break;
                }
            }
            table = user.connBD.requestTable("calles");
            foreach (DataRow row in table.Tables[0].Rows)
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
            DataSet table = user.connBD.requestTable("departamentos");
            foreach (DataRow row in table.Tables[0].Rows)
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
            DataSet table = user.connBD.requestTable("calles");
            foreach (DataRow row in table.Tables[0].Rows)
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

            Object[,] insertPers = { { "rfc","nombre","app","apm","clvCalle" }, { rfc,nombre,apPat,apMat,clvCalle } };
            Object[,] insertEmpl = { { "clvE", "horario", "fechContr", "clvDep", "salario" }, { rfc, horario, fechContr, clvDep, salario } };
            
            user.connBD.insertInto(insertPers, "personas");
            user.connBD.insertInto(insertEmpl, "empleados");
            MessageBox.Show("Persona registrada");
        }

        

        private void downBoxEst_onItemSelected(object sender, EventArgs e)
        {
            if (downBoxEst.selectedIndex == 0)
            {
                lblMun.Visible = false;
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
            downBoxMun.Visible = true;
            DataSet table = user.connBD.requestTable("estados");
            foreach (DataRow row in table.Tables[0].Rows)
            {
                if (row["Nombre"].ToString().Equals(downBoxEst.selectedValue))
                {
                    nEst = Int32.Parse(row["clvEst"].ToString());
                    break;
                }
            }
            table = user.connBD.requestTable("municipios");
            foreach (DataRow row in table.Tables[0].Rows)
            {
                if (Int32.Parse(row["clvEst"].ToString()) == nEst)
                {
                    downBoxMun.AddItem(row["Nombre"].ToString());
                }
            }
        }
    }
}
