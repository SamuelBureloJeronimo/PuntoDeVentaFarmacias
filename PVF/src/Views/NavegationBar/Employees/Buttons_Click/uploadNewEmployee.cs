using PVF.Models;
using PVF.src.Controllers;
using System;
using System.Data;
using System.Windows.Forms;

namespace PVF.src.Views.NavegationBar.Employees.Buttons_Click
{
    public partial class uploadNewEmployee : UserControl
    {
        public uploadNewEmployee()
        {
            InitializeComponent();
        }
        public void getDeps(object ob, EventArgs e)
        {
            downBoxDep.Items.Clear();
            DepartamentController dc = new DepartamentController();
            DataSet dm = dc.getDeps();
            foreach (DataRow row in dm.Tables[0].Rows)
            {
                downBoxDep.Items.Add(row["nombDep"]);
            }
        }
        public void getStates(object ob, EventArgs e)
        {
            downBoxEst.Items.Clear();
            StateController dc = new StateController();
            DataSet dm = dc.getStates();
            foreach (DataRow row in dm.Tables[0].Rows)
            {
                downBoxEst.Items.Add(row["Nombre"]);
            }
        }
    }
}
