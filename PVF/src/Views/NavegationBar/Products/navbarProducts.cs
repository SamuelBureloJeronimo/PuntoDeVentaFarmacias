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
            removeAllCollection();
            Register register = new Register();
            collection = register;
            register.Dock = DockStyle.Fill;
            panel.Controls.Add(register);
        }
        private void removeAllCollection()
        {
            if (collection is Register)
            {
                Register reg = (Register)collection;
                panel.Controls.Remove(reg);
                reg.Dispose();
                Console.WriteLine("Es register");
                return;
            }
            if (collection is IncomeInquiries)
            {
                IncomeInquiries inquiries = (IncomeInquiries)collection;
                panel.Controls.Remove(inquiries);
                inquiries.Dispose();
                Console.WriteLine("Es Inquiries");
                return;
            }
        }

        private void btnConsultIngre_Producto_Click(object sender, EventArgs e)
        {
            if (collection is IncomeInquiries)
                return;
            removeAllCollection();
            IncomeInquiries inquiries = new IncomeInquiries();
            collection = inquiries;
            inquiries.Dock = DockStyle.Fill;
            panel.Controls.Add(inquiries);
        }
    }
}
