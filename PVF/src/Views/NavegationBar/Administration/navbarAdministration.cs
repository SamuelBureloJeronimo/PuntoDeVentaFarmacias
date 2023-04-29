using PVF.src.Controllers;
using PVF.src.Views.NavegationBar.Administration.Buttons_Click;
using System;
using System.Windows.Forms;

namespace PVF.src.Views.NavegationBar.Administration
{
    public partial class navbarAdministration : UserControl
    {
        ResourseController rc;
        public navbarAdministration(ResourseController rc)
        {
            this.rc = rc;
            InitializeComponent();
        }

        private void CreateNewUser_Click(object sender, EventArgs e)
        {
            rc.add(new uploadNewUser());
        }
    }
}
