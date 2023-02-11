using Bunifu.Framework.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PVF
{
    /**
     * Esta clase es la controla el acceso a los datos del usuario,
     * es la principal.
     * @author: Samuel Burelos Jerónimo
     * @version: 05/02/2023
     */
    public partial class menuPrincipal : Form
    {
        //Variables y objetos necesarios
        private Usuario user;
        public TabPage pd;
        private AltaProductos atpd;
        private string datetime = DateTime.Now.ToString("hh:mm tt");
        private Stopwatch timeMeasure = new Stopwatch();
        private AltaProductos altaProductos= new AltaProductos();
        private SubMenusItems subMenus = new SubMenusItems();
        private ArrayList BDmedicamentos = new ArrayList();
        /**
         *  Contructor de la clase menuPrincipal
         *  @param us El parametro us es el nombre de usuario
         *  @param clv Es la clave de acceso del usuario
         *  @param tipo Es tipo de usuario que es usuario (Empleado, Gerente, Administrador)
         */
        public menuPrincipal()
        {
            
        }
        public menuPrincipal(string us, string clv, string tipo)
        {
            user = new Usuario(us, clv, tipo);
            InitializeComponent();//Se inicializan los componentes del proyecto
            myInitializateComponents();//Se inicializan los componentes traidos de otra clase/form

            //Control de acceso
            switch (user.Tipo)
            {
                case "Empleado":
                    Empleado empl = new Empleado();
                    empl.Show();
                    break;
                case "Gerente":
                    MessageBox.Show("Bienvenido Gerenete " + user.Nombre + ".\nUltima vez conectado: " + datetime, "¡Bienvenido Gerente!", MessageBoxButtons.OK);
                    btnfuProveedores.Visible = false;
                    btnfuEmpleados.Visible = false;
                    btnfuAdministracion.Visible = false;
                    label2.Text = "     " + user.Nombre + " [Gerente]";
                    this.Show();
                    break;
                case "Admin":
                    MessageBox.Show("Bienvenido Administrador "+user.Nombre+".\nUltima vez conectado: "+ datetime, "¡Bienvenido Administrador!", MessageBoxButtons.OK);
                    label2.Text = "     "+user.Nombre+" [Administrador]";
                    this.Show();
                    break;
                default: 
                    break;
            } 
        }
        /**
         *  Este metodo incializa los componentes extenernos e internos del proyecto fuera de la vista previa [Design]
         */
        public void myInitializateComponents()
        {
            //Se incializan agrega los subMenus para tenerlos a la mano
            panelSubMenu.Controls.Add(subMenus.panelProductos);
            panelSubMenu.Controls.Add(subMenus.panelClientes);
            panelSubMenu.Controls.Add(subMenus.panelCompras);
            panelSubMenu.Controls.Add(subMenus.panelVentas);
            panelSubMenu.Controls.Add(subMenus.panelProveedores);
            panelSubMenu.Controls.Add(subMenus.panelEmpleados);
            panelSubMenu.Controls.Add(subMenus.panelReportes);
            panelSubMenu.Controls.Add(subMenus.panelCaja);
            panelSubMenu.Controls.Add(subMenus.panelAdministracion);
            panelSubMenu.Controls.Add(subMenus.panelAyuda);

            //Agrego los metodos al dar click en los botones
            subMenus.btnAltaEdicion_Producto.Click += new System.EventHandler(this.btnAltaEdicion_Producto_Click);
            subMenus.btnConsultIngre_Producto.Click += new System.EventHandler(this.btnConsultIngre_Producto_Click);


            //Modifico el dock para que ocupe todo el espacio asignado
            subMenus.panelClientes.Dock = DockStyle.Fill;
            subMenus.panelProductos.Dock = DockStyle.Fill;
            subMenus.panelCompras.Dock = DockStyle.Fill;
            subMenus.panelVentas.Dock= DockStyle.Fill;
            subMenus.panelProveedores.Dock= DockStyle.Fill;
            subMenus.panelEmpleados.Dock= DockStyle.Fill;
            subMenus.panelReportes.Dock= DockStyle.Fill;
            subMenus.panelCaja.Dock= DockStyle.Fill;
            subMenus.panelAdministracion.Dock= DockStyle.Fill;
            subMenus.panelAyuda.Dock= DockStyle.Fill;

            timeMeasure.Start();//Inicia el timer de la Barra de estado
            timer1.Enabled = true;
            labelStatus1.Text = DateTime.Now.ToString("hh:mm tt");//Se agrega el timer al label de la barra

        }
        private void btnConsultIngre_Producto_Click(object sender, EventArgs e)
        {
            int pageIndex = tabControl.TabCount;
            for (int i = 0; i < tabControl.TabCount; i++)
            {
                if (tabControl.TabPages[i].Text.Equals("Consulta de Ingresos"))
                {
                    tabControl.SelectedIndex = i;
                    //MessageBox.Show("La pagina ya existe.");
                    return;
                }
            }
            ConsultaDeIngresos at = new ConsultaDeIngresos();
            for(int i=0;i<BDmedicamentos.Count;i++)
            {
                at.bdMedic.Rows.Add();
                Medicamento md = (Medicamento)BDmedicamentos[i];
                double inversion = md.PrecioCompra * md.Cantidad;
                double ganancias = md.PrecioVenta * md.Cantidad;

                at.bdMedic[0, i].Value = md.Codigo;
                at.bdMedic[1, i].Value = md.Nombre;
                at.bdMedic[2, i].Value = md.PrecioCompra.ToString();
                at.bdMedic[3, i].Value = md.PrecioVenta.ToString();
                at.bdMedic[4, i].Value = md.Tipo;
                at.bdMedic[5, i].Value = md.Cantidad.ToString();
                at.bdMedic[6, i].Value = (md.Iva*100).ToString();
                at.bdMedic[7, i].Value = md.Caducidad;
                at.bdMedic[8, i].Value = inversion.ToString();
                at.bdMedic[9, i].Value = ganancias.ToString();
            }
            at.bttonClose.Click += new System.EventHandler(btnClose_Click);

            pd = new TabPage();
            pd.Text = "Consulta de Ingresos";
            tabControl.TabPages.Add(pd);

            pd.Controls.Add(at.panelForm);
            at.panelForm.Dock = DockStyle.Fill;
            at.panelForm.Show();
            tabControl.SelectedIndex= pageIndex;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(atpd.boxCodigo.Text.Equals("") || atpd.boxName.Text.Equals("") || atpd.boxPrecioCompra.Text.Equals("") || atpd.boxPrecioVenta.Text.Equals("")){
                MessageBox.Show("Debes rellenar todos los campos.");
                return;
            }
            if(atpd.downBoxTipo.selectedIndex == 0 || atpd.boxLote.Text.Equals("") || atpd.boxIva.Text.Equals("") || atpd.FileName == null){
                MessageBox.Show("Debes rellenar todos los campos.");
                return;
            }
            string codigo   = atpd.boxCodigo.Text;
            string nombre   = atpd.boxName.Text;
            double precioC  = Convert.ToDouble(atpd.boxPrecioCompra.Text);
            double precioV  = Convert.ToDouble(atpd.boxPrecioVenta.Text);
            string tipo     = atpd.downBoxTipo.selectedValue;
            int cantidad    = Int32.Parse(atpd.boxLote.Text);
            double iva      = Convert.ToDouble(atpd.boxIva.Text);
            string fechCadu = atpd.fechCaducidad.Value.ToLongDateString();
            string url      = atpd.FileName;
            Medicamento med = new Medicamento(codigo,nombre,precioC,precioV,tipo,cantidad,iva,fechCadu,url);
            BDmedicamentos.Add(med);
            MessageBox.Show("Se registro correctamente.");

            atpd.boxCodigo.Text = string.Empty;
            atpd.boxName.Text = string.Empty;
            atpd.boxPrecioCompra.Text = string.Empty;
            atpd.boxPrecioVenta.Text = string.Empty;
            atpd.boxLote.Text = string.Empty;
            atpd.boxIva.Text = string.Empty;

            atpd.lblCodigo.Visible = false;
            atpd.lblName.Visible = false;
            atpd.lblPrecioCompra.Visible = false;
            atpd.lblPrecioVenta.Visible = false;
            atpd.lblLote.Visible = false;
            atpd.lblIVA.Visible = false;

            atpd.downBoxTipo.selectedIndex = 0;
            atpd.pictureBox1.Image= null;
            atpd.FileName= string.Empty;
        }

        // BunifuFlatButton     bttonClose
        //
        // Cierra el proyecto
        //
        private void bttonClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que deseas salir?", "¡Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
        // BunifuFlatButton     bttonMinWindow
        //
        // Minimiza la venta de esta clase
        //
        private void bttonMinWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            bttonMax.Visible = true;
            bttonMin.Visible = false;
        }
        
        // BunifuFlatButton     bttonMax
        // Maximiza la ventana de esta clase
        //
        private void bttonMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            bttonMax.Visible = false;
            bttonMin.Visible = true;
        }
        
        // BunifuFlatButton     bttonMin
        // Muestra la ventana con el tamaño predifinido
        //
        private void bttonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            bttonMax.Visible = true;
            bttonMin.Visible = false;
        }
        /**
         * Método para borrar la config de los componentes del menu y solo modificar el que se selecciono
         * @param btn1 es un BunifuFlatButton y es el boton que sera modificado, los demas se resetean por default
         */
        private void selectMenu(BunifuFlatButton btn1)
        {
            //Cambia el color a transparente de todo el menu
            btnfuProductos.Normalcolor  = Color.Transparent;
            btnfuClientes.Normalcolor   = Color.Transparent;
            btnfuCompras.Normalcolor    = Color.Transparent;
            btnfuVentas.Normalcolor     = Color.Transparent;
            btnfuProveedores.Normalcolor = Color.Transparent;
            btnfuEmpleados.Normalcolor   = Color.Transparent;
            btnfuCaja.Normalcolor       = Color.Transparent;
            btnfuReportes.Normalcolor   = Color.Transparent;
            btnfuAdministracion.Normalcolor = Color.Transparent;
            btnfuAyuda.Normalcolor          = Color.Transparent;
            //Cuando pasa el mouse por el boton se pone de color PaleTurquoise
            btnfuProductos.OnHovercolor = Color.PaleTurquoise;
            btnfuClientes.OnHovercolor = Color.PaleTurquoise;
            btnfuCompras.OnHovercolor = Color.PaleTurquoise;
            btnfuVentas.OnHovercolor = Color.PaleTurquoise;
            btnfuProveedores.OnHovercolor = Color.PaleTurquoise;
            btnfuEmpleados.OnHovercolor = Color.PaleTurquoise;
            btnfuCaja.OnHovercolor = Color.PaleTurquoise;
            btnfuReportes.OnHovercolor = Color.PaleTurquoise;
            btnfuAdministracion.OnHovercolor = Color.PaleTurquoise;
            btnfuAyuda.OnHovercolor = Color.PaleTurquoise;
            //Cambia el color de letra cuando se da Click al boton
            btnfuProductos.Textcolor = Color.Black;
            btnfuClientes.Textcolor = Color.Black;
            btnfuCompras.Textcolor = Color.Black;
            btnfuVentas.Textcolor = Color.Black;
            btnfuProveedores.Textcolor = Color.Black;
            btnfuEmpleados.Textcolor = Color.Black;
            btnfuCaja.Textcolor = Color.Black;
            btnfuReportes.Textcolor = Color.Black;
            btnfuAdministracion.Textcolor = Color.Black;
            btnfuAyuda.Textcolor = Color.Black;
            //Se configura solamente el boton que se seleccion
            btn1.Normalcolor    = Color.DarkCyan;
            btn1.Textcolor      = Color.White;
            btn1.OnHovercolor   = Color.DarkCyan;
        }
        /**
         * Este metodo muestra el panel del SubMenu de la clase SubMenuItems,
         * el cual contiene los submenus de cada una de las secciones como:
         * productos, clientes, compras, ventas, etc. Las demás las oculta
         * @param subP Es de tipo Panel y es el que se muestra
         */
        public void showItemSubmenu(Panel subP)
        {
            subMenus.panelProductos.Hide();
            subMenus.panelClientes.Hide();
            subMenus.panelCompras.Hide();
            subMenus.panelVentas.Hide();
            subMenus.panelProveedores.Hide();
            subMenus.panelEmpleados.Hide();
            subMenus.panelReportes.Hide();
            subMenus.panelCaja.Hide();
            subMenus.panelAdministracion.Hide();
            subMenus.panelAyuda.Hide();
            subP.Show();
        }
        // MENU
        // BunifuFlatButton     btnfuProductos
        //
        private void btnfuProductos_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuProductos);
            showItemSubmenu(subMenus.panelProductos);
            subMenus.panelProductos.Show();
        }
        public void btnClose_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tabControl.TabPages[tabControl.SelectedIndex]);
            //tabControl.TabPages[0].Visible = false;
        }
        private void btnAltaEdicion_Producto_Click(object sender, EventArgs e)
        {
            int pageIndex = tabControl.TabCount;
            for(int i=0; i<tabControl.TabCount;i++)
            {
                if (tabControl.TabPages[i].Text.Equals("Alta/Edición"))
                {
                    tabControl.SelectedIndex = i;
                    //MessageBox.Show("La pagina ya existe.");
                    return;
                }
                
            }
            atpd = new AltaProductos();
            atpd.bttonClose.Click += new System.EventHandler(btnClose_Click);
            atpd.btnRegistrar.Click += new System.EventHandler(btnRegister_Click);

            pd = new TabPage();
            pd.Text = "Alta/Edición";
            tabControl.TabPages.Add(pd);

            pd.Controls.Add(atpd.panelForm);
            atpd.panelForm.Dock= DockStyle.Fill;
            atpd.panelForm.Show();
            tabControl.SelectedIndex=pageIndex;
            
        }
        //
        // BunifuFlatButton     btnfuClientes
        //
        private void btnfuClientes_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuClientes);
            showItemSubmenu(subMenus.panelClientes);
            subMenus.panelClientes.Show();
        }
        //
        // BunifuFlatButton     btnfuCompras
        //
        private void btnfuCompras_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuCompras);
            showItemSubmenu(subMenus.panelCompras);
            subMenus.panelCompras.Show();
        }
        //
        // BunifuFlatButton     btnfuVentas
        //
        private void btnfuVentas_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuVentas);
            showItemSubmenu(subMenus.panelVentas);
            subMenus.panelVentas.Show();
        }
        //
        // BunifuFlatButton     btnfuProveedores
        //
        private void btnfuProveedores_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuProveedores);
            showItemSubmenu(subMenus.panelProveedores);
            subMenus.panelProveedores.Show();
        }
        //
        // BunifuFlatButton     btnfuEmpleados
        //
        private void btnfuEmpleados_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuEmpleados);
            showItemSubmenu(subMenus.panelEmpleados);
            subMenus.panelEmpleados.Show();
        }
        //
        // BunifuFlatButton     btnfuCaja
        //
        private void btnfuCaja_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuCaja);
            showItemSubmenu(subMenus.panelCaja);
            subMenus.panelCaja.Show();
        }
        //
        // BunifuFlatButton     btnfuReportes
        //
        private void btnfuReportes_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuReportes);
            showItemSubmenu(subMenus.panelReportes);
            subMenus.panelReportes.Show();
        }
        //
        // BunifuFlatButton     btnfuAdministracion
        //
        private void btnfuAdministracion_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuAdministracion);
            showItemSubmenu(subMenus.panelAdministracion);
            subMenus.panelAdministracion.Show();
        }
        //
        // BunifuFlatButton     btnfuAyuda
        //
        private void btnfuAyuda_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuAyuda);
            showItemSubmenu(subMenus.panelAyuda);
            subMenus.panelAyuda.Show();
        }
        //
        // BunifuFlatButton     btnfuArchivo
        //
        private void btnfuArchivo_Click(object sender, EventArgs e)
        {
            panelLeftSide.Visible = true;
        }        
        //
        // Timer     timer1
        //
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0,0,0,0,(int)timeMeasure.ElapsedMilliseconds);
            labelStatus1.Text = "Tiempo de ejecución: "+ts.Hours.ToString()+":"+ts.Minutes+":"+ts.Seconds;
        }

        private void btnfuAtrasLeftSide_Click(object sender, EventArgs e)
        {
            panelLeftSide.Visible = false;
        }
    }
}
