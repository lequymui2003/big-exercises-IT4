using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QLDeTai
{
     class Nguoidung1cs
    {
        
        private string _username;
        private string _password;
        private string _confirmpassword;
        private string _email;

        public Nguoidung1cs()
        {
        }

        public Nguoidung1cs(string username, string password, string confirmpassword, string email)
        {
            _username = username;
            _password = password;
            _confirmpassword = confirmpassword;
            _email = email;
        }

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string Confirmpassword { get => _confirmpassword; set => _confirmpassword = value; }
        public string Email { get => _email; set => _email = value; }
    }
}
