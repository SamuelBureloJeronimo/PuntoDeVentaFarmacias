using PVF.Libraries;
using PVF.src.Models;
using System;
using System.Data;

namespace PVF.src.Controllers
{
    public class StateController
    {
        public DataSet getStates()
        {
            DB_Connector dB = new DB_Connector();
            return dB.requestTable("Estados");
        }
    }
}
