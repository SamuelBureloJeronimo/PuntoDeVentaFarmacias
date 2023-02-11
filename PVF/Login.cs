using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVF
{
    internal class Login
    {
        private string name, pass;
        public string Name
        {
            get { return name; } 
            set { name = value; } 
        }
        public string Pass
        {
            get { return pass; } 
            set { pass = value; } 
        }
    }
}
