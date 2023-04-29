using PVF.src.Views.NavegationBar.Products.Buttons;
using PVF.src.Views.NavegationBar.Products.Buttons_Click;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PVF.src.Views.NavegationBar.Administration
{
    public partial class navbarProducts : UserControl
    {
        private Panel panel;
        private Object collection;
        public navbarProducts(Panel panel)
        {
            this.panel  = panel;
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (collection is Register)
                return;
            panel.Controls.Clear();
            Register register = new Register();
            collection = register;
            panel.Controls.Add(register);
        }

        private void btnConsultIngre_Producto_Click(object sender, EventArgs e)
        {
            if (collection is IncomeInquiries)
                return;
            IncomeInquiries inquiries = new IncomeInquiries();
            collection = inquiries;
            panel.Controls.Add(inquiries);
        }
    }
}
