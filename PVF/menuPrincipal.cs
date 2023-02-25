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
using BarraHerramientaa;

namespace PVF
{
    /**
     * Esta clase es la controla el acceso a los datos del usuario,
     * es la principal.
     * @author: Samuel Burelos Jerónimo
     * @author: Martin Sanchez Reyes
     * @version: 05/02/2023
     */
    public partial class menuPrincipal : Form
    {
        //Variables y objetos necesarios
        private Usuario user;
        
        private string datetime = DateTime.Now.ToString("hh:mm tt");
        private Stopwatch timeMeasure = new Stopwatch();
        private AltaProductos altaProductos= new AltaProductos();
        private SubMenusItems subMenus = new SubMenusItems();
        private AltaProductos atpd;
        private Medicamentos BDM = new Medicamentos();

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

            TabPage pd = new TabPage();
            pd.Text = $"Bienvenido {user1.Nombre}";
            tabControl.TabPages.Add(pd);
            var welcome = new Welcome();
            pd.Controls.Add(welcome);
            welcome.Dock = DockStyle.Fill;
            welcome.Show();
            tabControl.SelectedIndex = 1;


        }

        //Este metodo permite cambiar el panel de acciones
        public void menuPanel(UserControl pane)
        {

            if(panelSubMenu.Controls.GetType() != pane.GetType()) //verificsmos que no exista el panel?
            {

                panelSubMenu.Controls.Clear();//limpiamos todos los controles de usuarios
                panelSubMenu.Controls.Add(pane); //agregamos el control de usuario deseado
            
            }

            
        }

        /**Metodo que verifica que no exista un pestana
         * recibe de parametro el titulo de la pestana
         */
        private void tabExistente(string title)
        {
            
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

            selectedPanelProductos();


           
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
                    return;
                }
            }
            ConsultaDeIngresos at = new ConsultaDeIngresos();
            for(int i=0;i<BDM.ListMedicamentos.Count;i++)
            {
                at.bdMedic.Rows.Add();
                Medicamentos md = (Medicamentos)BDM.ListMedicamentos[i];

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
            TabPage pd = new TabPage();
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
            BDM.Registrar(codigo, nombre, precioC, precioV, tipo, cantidad, iva, fechCadu, url);
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

        // MENU
        // BunifuFlatButton     btnfuProductos
        //

        //Este metodo permite mostrar el panel productos con todo y los eventos 
        private void selectedPanelProductos()
        {
            selectMenu(btnfuProductos);
            MenuProductos panelProductos = new MenuProductos();
            //Agrego los metodos al dar click en los botones
            panelProductos.btnAltaEdicion_Producto.Click += new System.EventHandler(this.btnAltaEdicion_Producto_Click);
            panelProductos.btnConsultIngre_Producto.Click += new System.EventHandler(this.btnConsultIngre_Producto_Click);
            menuPanel(panelProductos);
        }

        private void btnfuProductos_Click(object sender, EventArgs e)
        {
            selectedPanelProductos();
        }
        public void btnClose_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tabControl.TabPages[tabControl.SelectedIndex]);
            //tabControl.TabPages[0].Visible = false;
        }
        private void btnAltaEdicion_Producto_Click(object sender, EventArgs e)
        {
            int pageIndex = tabControl.TabCount;
            for (int i = 0; i < tabControl.TabCount; i++)
            {
                if (tabControl.TabPages[i].Text.Equals("Alta/Edición"))
                {
                    tabControl.SelectedIndex = i;

                    return;
                }

            }

            atpd = new AltaProductos();
            atpd.bttonClose.Click += new System.EventHandler(btnClose_Click);
            atpd.btnRegistrar.Click += new System.EventHandler(btnRegister_Click);

            TabPage pd = new TabPage();
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
            menuPanel(new MenuClientes());
        }
        //
        // BunifuFlatButton     btnfuCompras
        //
        private void btnfuCompras_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuCompras);
            menuPanel(new MenuCompras());
        }
        //
        // BunifuFlatButton     btnfuVentas
        //
        private void btnfuVentas_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuVentas);
            menuPanel(new MenuVentas());
        }
        //
        // BunifuFlatButton     btnfuProveedores
        //
        private void btnfuProveedores_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuProveedores);
            menuPanel(new MenuProveedores());
        }
        //
        // BunifuFlatButton     btnfuEmpleados
        //
        private void btnfuEmpleados_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuEmpleados);
            menuPanel(new MenuEmpleados());
        }
        //
        // BunifuFlatButton     btnfuCaja
        //
        private void btnfuCaja_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuCaja);
            menuPanel(new MenuCajas());
        }
        //
        // BunifuFlatButton     btnfuReportes
        //
        private void btnfuReportes_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuReportes);
            menuPanel(new MenuReportes());
        }
        //
        // BunifuFlatButton     btnfuAdministracion
        //
        private void btnfuAdministracion_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuAdministracion); //REMARCA LA OPCION SELECCIONADA

            MenuAdministracion pa = new MenuAdministracion(); //INSTANCIAMOS EL MENU

            pa.btnNewUser.Click += (s,m) => { //AGREGAMOS UN EVENTO PARA EL BOTON NEW USER
                
                AltaUsuarios au = new AltaUsuarios(); // DENTRO DEL EVENTO INSTANCIAMOS EL PANEL QUE QUEREMOS MOSTRAR

                int pageIndex = tabControl.TabCount;
                for (int i = 0; i < tabControl.TabCount; i++)
                {
                    if (tabControl.TabPages[i].Text.Equals("Alta Usuario"))
                    {
                        tabControl.SelectedIndex = i;
                        //MessageBox.Show("La pagina ya existe.");
                        return;
                    }

                }

                au.bttonClose.Click += (btnClose_Click);
                au.btnRegistrar.Click += (x, d) =>
                {
                    MessageBox.Show("Si funciona");
                };

                TabPage pd = new TabPage();
                pd.Text = "Alta Usuario";
                tabControl.TabPages.Add(pd);
                au.Dock= DockStyle.Fill;
                pd.Controls.Add(au);
                tabControl.SelectedIndex = pageIndex;
            };


           menuPanel(pa);//Mostramos el panel con todo xd
        }
        //
        // BunifuFlatButton     btnfuAyuda
        //
        private void btnfuAyuda_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuAyuda);
            menuPanel(new MenuAyuda());
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
