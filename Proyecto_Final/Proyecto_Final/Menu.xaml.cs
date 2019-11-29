using Proyecto_Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_Final
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public string NombreUsuario { get; set; }
        public Menu()
        {
            InitializeComponent();
            Item1.Clicked += Item1_Clicked;
            Item2.Clicked += Item2_Clicked;
        }

        private async void Item1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Viesta() { NombreUsuario = NombreUsuario });
        }

        private async void Item2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Nuevo_Caso() { NombreUsuario = NombreUsuario });
        }
    }
}