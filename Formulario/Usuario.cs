using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario
{
    class Usuario
    {

        private string _username;
        private string _password;
        private DateTime _fechaNacimiento;

        public Usuario(string username, string password, DateTime fechaNacimiento)
        {
            _username = username;
            _password = password;
            _fechaNacimiento = fechaNacimiento;
        }

        public string GetUsername()
        {
            return _username;
        }

        public string GetPassword()
        {
            return _password;
        }

        public DateTime GetFechaNacimiento()
        {
            return _fechaNacimiento;
        }

    }
}
