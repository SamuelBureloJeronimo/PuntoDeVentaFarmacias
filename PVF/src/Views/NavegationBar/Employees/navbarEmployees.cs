using PVF.src.Controllers;
using PVF.src.Views.NavegationBar.Employees.Buttons_Click;
using System;
using System.Windows.Forms;

namespace PVF.src.Views.NavegationBar.Employees
{
    public partial class navbarEmployees : UserControl
    {
        ResourseController rc;
        public navbarEmployees(ResourseController rc)
        {
            this.rc = rc;
            InitializeComponent();
        }

        private void btnDarAlta_Click(object sender, EventArgs e)
        {
            rc.add(new uploadNewEmployee());
        }
    }
}
