using PVF.Libraries;
using PVF.Models;
using PVF.src.Models;
using System;
using System.Data;

namespace PVF.src.Controllers
{
    public class DepartamentController
    {
        public DepartamentModel getDep(String id = null, String name = null)
        {
            //Si ambos son null retornara null
            if (id == null && name == null)
                return null;
            //Busqueda por id
            if (id != null && name == null)
            {
                DB_Connector dB = new DB_Connector();
                DepartamentModel dm = new DepartamentModel();
                DataSet table = dB.requestTableWhere("Departamentos", "clvD", id);
                foreach (DataRow row in table.Tables[0].Rows)
                {
                    dm.clv = row["clvD"].ToString();
                    dm.name = row["nombDep"].ToString();
                }
                return dm;
            }
            //Busqueda por nombre
            if (id == null && name != null)
            {
                DB_Connector dB = new DB_Connector();
                DepartamentModel dm = new DepartamentModel();
                DataSet table = dB.requestTableWhere("Departamentos", "nombDep", name);
                foreach (DataRow row in table.Tables[0].Rows)
                {
                    dm.clv = row["clvD"].ToString();
                    dm.name = row["nombDep"].ToString();
                }
                return dm;
            }
            return null;
        }
        public DataSet getDeps()
        {
            DB_Connector dB = new DB_Connector();
            return dB.requestTable("Departamentos");
        }
    }
}
