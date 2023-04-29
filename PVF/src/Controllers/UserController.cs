using PVF.Libraries;
using System;
using System.Windows.Forms;

namespace PVF.Controllers
{
    public class UserController
    {
        private DB_Connector connect;
        public Boolean login(string email, string pass)
        {
            connect = new DB_Connector();
            //Excepción #1: Usuario o contraseña incorrecta
            String[,] columsCmpr = { { "email", "password" }, { email, pass } };
            if (connect.compareDFT(columsCmpr, "users"))
            {
                return true;
            }
            return false;
        }
    }
}
