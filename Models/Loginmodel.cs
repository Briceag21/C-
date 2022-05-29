using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Models
{
    internal class Loginmodel
    {
        private string username;
        private string password;
       public string  Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
