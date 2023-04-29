using Bunifu.Framework.UI;
using PVF.src.Controllers;
using PVF.src.Views.NavegationBar.Administration;
using PVF.src.Views.NavegationBar.Clients;
using PVF.src.Views.NavegationBar.Employees;
using PVF.src.Views.NavegationBar.Fund;
using PVF.src.Views.NavegationBar.Help;
using PVF.src.Views.NavegationBar.Providers;
using PVF.src.Views.NavegationBar.Reports;
using PVF.src.Views.NavegationBar.Sales;
using PVF.src.Views.NavegationBar.Shopping;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

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
        private readonly ResourseController collection;
        /**
         *  Contructor de la clase menuPrincipal
         */
        public menuPrincipal()
        {
            InitializeComponent();

            selectMenu(btnfuProductos);
            this.collection = new ResourseController(panelBody);
            showItemSubmenu(new navbarProducts(collection));
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
            this.Width = 1050;
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
        private void showItemSubmenu(UserControl uc)
        {
            panelSubMenu.Controls.Clear();
            panelSubMenu.Controls.Add(uc);
            uc.Show();
        }
        // MENU
        // BunifuFlatButton     btnfuProductos
        //
        private void btnfuProductos_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuProductos);
            showItemSubmenu(new navbarProducts(collection));
        }
        //
        // BunifuFlatButton     btnfuClientes
        //
        private void btnfuClientes_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuClientes);
            showItemSubmenu(new navbarClients());
        }
        //
        // BunifuFlatButton     btnfuCompras
        //
        private void btnfuCompras_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuCompras);
            showItemSubmenu(new navbarShopping());
        }
        //
        // BunifuFlatButton     btnfuVentas
        //
        private void btnfuVentas_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuVentas);
            showItemSubmenu(new navbarSales());
        }
        //
        // BunifuFlatButton     btnfuProveedores
        //
        private void btnfuProveedores_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuProveedores);
            showItemSubmenu(new navbarProviders());
        }
        //
        // BunifuFlatButton     btnfuEmpleados
        //
        private void btnfuEmpleados_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuEmpleados);
            showItemSubmenu(new navbarEmployees());
        }
        //
        // BunifuFlatButton     btnfuCaja
        //
        private void btnfuCaja_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuCaja);
            showItemSubmenu(new navbarFunds());
        }
        //
        // BunifuFlatButton     btnfuReportes
        //
        private void btnfuReportes_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuReportes);
            showItemSubmenu(new navbarReports());
        }
        //
        // BunifuFlatButton     btnfuAdministracion
        //
        private void btnfuAdministracion_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuAdministracion);
            showItemSubmenu(new navbarAdministration());
        }
        //
        // BunifuFlatButton     btnfuAyuda
        //
        private void btnfuAyuda_Click(object sender, EventArgs e)
        {
            selectMenu(btnfuAyuda);
            showItemSubmenu(new navbarHelp());
        }
        //
        // BunifuFlatButton     btnfuArchivo
        //
        private void btnfuArchivo_Click(object sender, EventArgs e)
        {
            panelLeftSide.Visible = true;
        }
        private void btnfuAtrasLeftSide_Click(object sender, EventArgs e)
        {
            panelLeftSide.Visible = false;
        }
    }
}
