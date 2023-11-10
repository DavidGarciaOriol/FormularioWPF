using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Formulario
{
    public partial class MainWindow : Window
    {

        string password;
        string usuario;
        DateTime fechaNacimiento;

        
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Enviar_Click(object sender, RoutedEventArgs e)
        {
            password = ""; // TextBox de Password
            usuario = ""; // TextBox de Usuario
            fechaNacimiento = DateTime.Now; // Cambiar para obtener Fecha de Nacimiento de DatePicker

            ComprobarPassword(password);
            ComprobarUsuario(usuario);
            ComprobarEdad(fechaNacimiento);

        }

        private static void ComprobarPassword(string password)
        {
            Regex regexPassword = new("^(?=.*\\d)(?=.*[a - z])(?=.*[A - Z])(?=.*[a - zA - Z]).{8,12}$");
            if (!regexPassword.IsMatch(password))
            {
                // TO DO
            } else
            {
                // TO DO
            }
        }

        private static void ComprobarUsuario(string usuario)
        {
            if (usuario.Equals(""))
            {
                // TO DO
            } else
            {
                // TO DO
            }
        }

        private static void ComprobarEdad(DateTime fechaNacimiento)
        {
            
            if (MayorDeEdad(fechaNacimiento) < 18)
            {
                // TO DO
            } else
            {
                // TO DO
            }

        }

        private static int MayorDeEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            if (fechaActual.Month < fechaNacimiento.Month || (fechaActual.Month == fechaNacimiento.Month && fechaActual.Day < fechaNacimiento.Day)) edad--;
            return edad;
        }

        private void ConectarSQLiteBBDD()
        {
            // TO DO
        }
    }
}
