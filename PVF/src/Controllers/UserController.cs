using PVF.Libraries;
using System;
using System.Windows.Forms;

namespace PVF.Controllers
{
    public class UserController
    {
        private DB_Connector connect;
        public UserController() 
        {
            connect = new DB_Connector("localhost", "3306", "root", "", "pvf");
        }
        public Boolean login(string email, string pass)
        {
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
