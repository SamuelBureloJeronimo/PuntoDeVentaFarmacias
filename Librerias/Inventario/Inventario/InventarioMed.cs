using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    public class InventarioMed
    {
        ArrayList inventario = new ArrayList();
        Medicamento med1;
        public InventarioMed()
        {
            med1 = new Medicamento();
        }
        public void Registrar(string codigo, string nombre, double pC, double pV, string tipo, int cantidad, double iva, string caducidad, string urlIMG)
        {
            med1.registrar(codigo, nombre, pC, pV, tipo, cantidad, iva, caducidad, urlIMG);
            inventario.Add(med1);
        }
        public ArrayList Inventario { get { return inventario; } set { inventario = value; } }
    }
}
