using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CristianGranda
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            string usuario = "cris123";
            string contrasena = "12345";

            string tUsuario = txtUsuario.Text;
            string tContrasena = txtContrasena.Text;

            if (usuario == tUsuario & contrasena == tContrasena)
            {
                DisplayAlert("Alerta", "USUARIO CORRECTO" + " Bienvenido: " + usuario, "Cerrar");
                Navigation.PushAsync(new Registro(txtUsuario.Text));
            }
            else
            {
                DisplayAlert("Alerta", "USUARIO INCORRECTO O NO EXISTE", "Cerrar");
            }
        }
    }
}