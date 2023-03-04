using Bunifu.Framework.UI;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Inventario;
using BarraNavegacion;
using ControlUsuario;


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

        private MenusItem   menus;

        private string datetime;
        private Stopwatch timeMeasure;
        private InventarioMed inventario;

        /**
         *  Contructor de la clase menuPrincipal
         *  <param name="user1">Es un objeto tipo Usuario que contiene nombre, clave y tipo</param>
         */
        public menuPrincipal(Usuario user1)
        {
            user = user1;
            InitializeComponent();//Se inicializan los componentes del proyecto
            InicializarMisComponentes();//Se inicializan los componentes traidos de otra clase/form
            controlAcceso();
        }
        private void controlAcceso()
        {
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
                    MessageBox.Show("Bienvenido Administrador " + user.Nombre + ".\nUltima vez conectado: " + datetime, "¡Bienvenido Administrador!", MessageBoxButtons.OK);
                    label2.Text = "     " + user.Nombre + " [Administrador]";
                    this.Show();
                    break;
                default:
                    break;
            }
        }
        public void InicializarMisComponentes()
        {
            datetime = DateTime.Now.ToString("hh:mm tt");
            timeMeasure = new Stopwatch();
            inventario = new InventarioMed();

            menus = new MenusItem(tabControl, inventario);
            panelSubMenu.Controls.Add(menus.panelProductos);
            menus.panelProductos.Show();
            
            //subMenus.btnAltaEdicion_Producto.Click += new System.EventHandler(this.btnAltaEdicion_Producto_Click);
            //Modifico el dock para que ocupe todo el espacio asignado
            menus.panelProductos.Dock = DockStyle.Fill;
            menus.panelClientes.Dock = DockStyle.Fill;
            menus.panelCompras.Dock = DockStyle.Fill;
            menus.panelVentas.Dock= DockStyle.Fill;
            menus.panelProveedores.Dock= DockStyle.Fill;
            menus.panelEmpleados.Dock= DockStyle.Fill;
            menus.panelCaja.Dock= DockStyle.Fill;
            menus.panelReportes.Dock = DockStyle.Fill;
            menus.panelAdministracion.Dock= DockStyle.Fill;
            menus.panelAyuda.Dock= DockStyle.Fill;

            timeMeasure.Start();//Inicia el timer de la Barra de estado
            timer1.Enabled = true;
            labelStatus1.Text = DateTime.Now.ToString("hh:mm tt");//Se agrega el timer al label de la barra

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
         * <summary>
         * Método para borrar la config de los componentes del menu y solo modificar el que se selecciono
         * </summary>
         * <param name="btn1">
         * Es un BunifuFlatButton y es el boton que sera modificado, los demas se resetean por default
         * </param> 
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
         * <summary>
         *      Este metodo muestra el panel del SubMenu de la clase SubMenuItems,
         * el cual contiene los submenus de cada una de las secciones como:
         * productos, clientes, compras, ventas, etc. Las demás las oculta
         * </summary>
         * <param name="subP">
         *      Es de tipo Panel y es el que se muestra
         * </param>
         */
        private void showItemSubmenu(Panel subP)
        {
            panelSubMenu.Controls.Clear();
            panelSubMenu.Controls.Add(subP);
            subP.Show();
        }
        // MENU
        // BunifuFlatButton     btnfuProductos
        //
        private void btnfuProductos_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuProductos);
            showItemSubmenu(menus.panelProductos);
        }
        //
        // BunifuFlatButton     btnfuClientes
        //
        private void btnfuClientes_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuClientes);
            showItemSubmenu(menus.panelClientes);
        }
        //
        // BunifuFlatButton     btnfuCompras
        //
        private void btnfuCompras_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuCompras);
            showItemSubmenu(menus.panelCompras);
        }
        //
        // BunifuFlatButton     btnfuVentas
        //
        private void btnfuVentas_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuVentas);
            showItemSubmenu(menus.panelVentas);
        }
        //
        // BunifuFlatButton     btnfuProveedores
        //
        private void btnfuProveedores_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuProveedores);
            showItemSubmenu(menus.panelProveedores);
        }
        //
        // BunifuFlatButton     btnfuEmpleados
        //
        private void btnfuEmpleados_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuEmpleados);
            showItemSubmenu(menus.panelEmpleados);
        }
        //
        // BunifuFlatButton     btnfuCaja
        //
        private void btnfuCaja_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuCaja);
            showItemSubmenu(menus.panelCaja);
        }
        //
        // BunifuFlatButton     btnfuReportes
        //
        private void btnfuReportes_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuReportes);
            showItemSubmenu(menus.panelReportes);
        }
        //
        // BunifuFlatButton     btnfuAdministracion
        //
        private void btnfuAdministracion_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuAdministracion);
            showItemSubmenu(menus.panelAdministracion);
        }
        //
        // BunifuFlatButton     btnfuAyuda
        //
        private void btnfuAyuda_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuAyuda);
            showItemSubmenu(menus.panelAyuda);
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
