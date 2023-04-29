using PVF.src.Controllers;
using PVF.src.Views.NavegationBar.Products.Buttons;
using PVF.src.Views.NavegationBar.Products.Buttons_Click;
using System;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;

namespace PVF.src.Views.NavegationBar.Administration
{
    public partial class navbarProducts : UserControl
    {
        private ResourseController collection;
        public navbarProducts(ResourseController collection)
        {
            this.collection = collection;
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            collection.add(new Register());
        }

        private void btnConsultIngre_Producto_Click(object sender, EventArgs e)
        {
            collection.add(new IncomeInquiries());
        }
    }
}
