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

        private string password;
        private string username;
        private DateTime fechaNacimiento;

        
        
        public MainWindow()
        {
            InitializeComponent();
        }


        // Event Listeners

        private void Enviar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                username = nombreText.Text; // TextBox de Usuario
                password = passwordText.Text; // TextBox de Password
                fechaNacimiento = datePicker.SelectedDate.Value; // Cambiar para obtener Fecha de Nacimiento de DatePicker

                Usuario user;

                if (ComprobarPassword(password) && ComprobarUsuario(username) && ComprobarEdad(fechaNacimiento))
                {
                    user = new Usuario(username, password, fechaNacimiento);
                    agregarUsuarioBBDD(user);
                }
            } catch (Exception)
            {
                // TO DO
            }
        }


        // Métodos de Comprobación de parámetros

        private static bool ComprobarPassword(string password)
        {
            bool output;

            Regex regexPassword = new("^(?=.*\\d)(?=.*[a - z])(?=.*[A - Z])(?=.*[a - zA - Z]).{6,12}$");
            if (regexPassword.IsMatch(password))
            {
                // TO DO
                output = true;
            } else
            {
                // TO DO
                output = false;
            }

            return output;
        }

        private static bool ComprobarUsuario(string username)
        {
            bool output;
            if (!username.Equals("") && username != null)
            {
                // TO DO
                output = true;
            } else
            {
                // TO DO
                output = false;
            }

            return output;
        }

        private static bool ComprobarEdad(DateTime fechaNacimiento)
        {
            bool output;

            if (CalcularEdad(fechaNacimiento) >= 18)
            {
                // TO DO
                output = true;
            } else
            {
                // TO DO
                output = false;
            }

            return output;

        }

        private static int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            if (fechaActual.Month < fechaNacimiento.Month || (fechaActual.Month == fechaNacimiento.Month && fechaActual.Day < fechaNacimiento.Day)) edad--;
            return edad;
        }


        // MANEJADORES DE BASES DE DATOS

        private void agregarUsuarioBBDD(Usuario usuario)
        {
            // TO DO

            string usernameBBDD = usuario.GetUsername();
            string passwordBBDD = usuario.GetPassword();
            DateTime fechaNacimientoBBDD = usuario.GetFechaNacimiento();
        }
    }
}
