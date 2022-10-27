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
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "El usuario conectado es: " + usuario;
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string tNombre = txtNombre.Text;
            double mensual = Convert.ToDouble(txtMensual.Text);
            double total = Convert.ToDouble(txtTotal.Text);

            ///double total = restante + (mensual * 5);
            DisplayAlert("Alerta", "INFORMACION GUARDADA CORRECTAMENTE", "Cerrar");
            Navigation.PushAsync(new Resumen(txtNombre.Text, lblUsuario.Text, txtTotal.Text));

        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                DisplayAlert("Alerta", "Campo nombre obligatorio ", "Cerrar");

            }
            else if (string.IsNullOrWhiteSpace(txtMinicial.Text))
            {
                DisplayAlert("Alerta", "Campo Valor inicial obligatorio ", "Cerrar");
            }

            else
            {

            
            string nombre = txtNombre.Text;
            double minicial = Convert.ToDouble(txtMinicial.Text);
            double restante = 3000 - minicial;
            double mensual = (restante / 5) + ((restante / 5) * 0.05);
            double total = restante + (mensual * 5);
            
           
            if (minicial >3000 )
            {
                DisplayAlert("Alerta", "Valor inicial debe ser menor a 3000$ " , "Cerrar");
                txtMinicial.Text = "";

            }
            else if (minicial<0)
            {
                DisplayAlert("Alerta", "No se acepta valores negativos ", "Cerrar");
                txtMinicial.Text = "";
            }
            
            else 
            {
                DisplayAlert("Alerta", "El valor mensual a pagar es de: " + mensual.ToString()+"Dolares", "Cerrar");
                txtMensual.Text = mensual.ToString();
                txtTotal.Text = total.ToString();
            }
            }

        }
    }
}