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
    public partial class Resumen : ContentPage
    {
        public Resumen(string tNOmbre, string usuario, string total)
        {
            InitializeComponent();
            lblEstudiante.Text = "" +tNOmbre;
            lblUsuario.Text =  usuario+"$";
           /// lblMensual.Text = mensual;
            lblTotal.Text = total+"$";

        }
    }
}