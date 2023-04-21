using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Empleados;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace BarraNavegacion
{
    public partial class Administracion_CreateNewUser : UserControl
    {
        private Usuario user { get; set; }
        public Administracion_CreateNewUser(Usuario user)
        {
            this.user = user;
            InitializeComponent();
            DG.Columns[5].DefaultCellStyle.ForeColor = Color.Green;
            DG.MultiSelect= false;
        }

        private void buscar_KeyUp(object sender, KeyEventArgs e)
        {
            BunifuMaterialTextbox tb;
            if (sender is BunifuMaterialTextbox)
            {
                tb = sender as BunifuMaterialTextbox;
                DG.Rows.Clear();

                MySqlCommand command = new MySqlCommand("SELECT * FROM empleados", user.connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                int i = 0;
                foreach (DataRow row in table.Rows)
                {
                    String clvE = row["clvE"].ToString();
                    if (clvE.IndexOf(tb.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        DG.Rows.Add();
                        DG[0, i].Value = row["clvE"].ToString();
                        DG[1, i].Value = buscarNombre(clvE);
                        DG[2, i].Value = row["horario"].ToString();
                        DG[3, i].Value = row["fechContr"].ToString();
                        DG[4, i].Value = row["clvDep"].ToString();
                        DG[5, i].Value = row["Salario"].ToString();
                        i++;
                    }
                }
            }
        }
        public String buscarNombre(String clv)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM personas", user.connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                String clvE = row["rfc"].ToString();
                if (clvE.IndexOf(clv, StringComparison.OrdinalIgnoreCase) >= 0)
                    return row["nombre"].ToString();
            }
            return "No se encontro la clv: "+clv;
        }

        private void DG_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = DG.CurrentCell;
            int rowIndex = cell.RowIndex;
            uploadUser.Visible= true;
            uploadUser.Text = DG[1, rowIndex].Value.ToString();
        }
    }
}
