using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExemploCalculadoraXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            int numero, outroNumero, resultado;

            numero = int.Parse(txtNumero.Text);
            outroNumero = int.Parse(txtOutroNumero.Text);

            resultado = numero + outroNumero;

            DisplayAlert("Calcular", $"{numero} + {outroNumero} = {resultado}", "OK");

            txtNumero.Text = String.Empty;
            txtOutroNumero.Text = "";
        }
    }
}
