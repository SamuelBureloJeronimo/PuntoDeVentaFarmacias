using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVF
{
    internal class Medicamento
    {
        //El Iva esta en decimal osea 100% = 1, 10% = 0.1
        private string codigo, nombre, tipo, caducidad, urlIMG;
        private double presioCompra, precioVenta, iva;
        private int cantidad;
        public Medicamento(string codigo, string nombre, double pC, double pV, string tipo, int cantidad, double iva, string caducidad, string urlIMG)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.presioCompra = pC;
            this.precioVenta = pV;
            this.tipo = tipo;
            this.cantidad = cantidad;
            this.iva = Convert.ToDouble(iva)/100;
            this.caducidad = caducidad;
            this.urlIMG = urlIMG;
        }
        //Metodos Getters y Setters
        public string Codigo{ get { return this.codigo; } set { this.codigo = value; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public double PrecioCompra { get { return this.presioCompra; } set { this.presioCompra = value; } }
        public double PrecioVenta { get { return this.precioVenta; } set { this.precioVenta = value; } }
        public string Tipo { get { return this.tipo; } set { this.tipo = value; } }
        public int Cantidad { get { return this.cantidad; } set { this.cantidad = value; } }
        public double Iva { get { return this.iva; } set { this.iva = value; } }
        public string Caducidad { get { return this.caducidad; } set { this.caducidad = value;} }
        public string Url { get { return this.urlIMG; } set { this.urlIMG = value; } }
    }
}
