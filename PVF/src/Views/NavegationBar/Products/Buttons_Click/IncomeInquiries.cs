using PVF.Libraries;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PVF.src.Views.NavegationBar.Products.Buttons_Click
{
    public partial class IncomeInquiries : UserControl
    {
        public IncomeInquiries()
        {
            InitializeComponent();
            loadTable();
        }
        public void loadTable()
        {
            bdMedic.Rows.Clear();
            DB_Connector db = new DB_Connector();
            DataSet ds = db.requestTable("productos");

            int i = 0;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                bdMedic.Rows.Add();
                double precComp = Double.Parse(row["precioComp"].ToString());
                double precVent = Double.Parse(row["precioVent"].ToString());
                int cantidad = int.Parse(row["cantidad"].ToString());

                double inversion = precComp * cantidad;
                double ganancias = precVent * cantidad;

                bdMedic[0, i].Value = row["clv"].ToString();
                bdMedic[1, i].Value = row["nombre"].ToString();
                bdMedic[2, i].Value = precComp.ToString();
                bdMedic[3, i].Value = precVent.ToString();
                bdMedic[4, i].Value = row["tipo"].ToString();
                bdMedic[5, i].Value = cantidad.ToString();
                bdMedic[6, i].Value = row["ivaPorc"] + "%";
                bdMedic[7, i].Value = row["caducidad"].ToString();
                bdMedic[8, i].Value = inversion.ToString();
                bdMedic[9, i].Value = ganancias.ToString();
                bdMedic.Columns[8].DefaultCellStyle.ForeColor = Color.Red;
                bdMedic.Columns[9].DefaultCellStyle.ForeColor = Color.Green;
                i++;
            }
            if (i < 1)
                Console.WriteLine("No se encontro nada en la Tabla producto.");
        }
    }
}
