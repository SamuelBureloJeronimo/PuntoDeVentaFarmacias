using PVF.src.Views.NavegationBar.Products.Buttons;
using System;
using System.Collections;
using System.Windows.Forms;

namespace PVF.src.Controllers
{
    public class ResourseController : IDisposable
    {
        public ArrayList index { get; set; }
        public Panel panelBody { get; set; }
        public ResourseController(Panel panel)
        {
            this.index = new ArrayList();
            this.panelBody = panel;
        }

        public void add(Object index) 
        {
            panelBody.Controls.Clear();
            Dispose();
            this.index.Add(index);
            UserControl reg = (UserControl)this.index[0];
            reg.Dock = DockStyle.Fill;
            panelBody.Controls.Add(reg);
            Console.WriteLine("Se agrego el usercontrol");
        }

        public void Dispose()
        {
            for (int i=0; i<index.Count; i++)
            {
                if (index[i] is UserControl)
                {
                    UserControl userControl = (UserControl)index[i];
                    index.Clear();
                    userControl.Dispose();
                    Console.WriteLine("Removido");
                }
            }
            
        }
    }
}
