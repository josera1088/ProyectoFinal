using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;

namespace Proyecto_Final
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ubicar : ContentPage
    {
        private List<Position> _posiciones = new List<Position>() {
            new Position(9.933459, -84.077056),
            new Position(-33.856562, 151.215683)
        };
        public Ubicar()
        {
            InitializeComponent();

        }

        protected override void OnAppearing()
        {

            Random random = new Random();
            int randomNumber = random.Next(1, 5);

            double longitud = 0;
            double lactitud = 0;

            switch (randomNumber)
            {

                case 1:
                    longitud = 9.850498;
                    lactitud = -83.956140;
                    break;
                case 2:
                    longitud = 9.979953;
                    lactitud = -84.832455;
                    break;
                case 3:
                    longitud = 9.657171;
                    lactitud = -82.752939;
                    break;
                case 4:
                    longitud = 9.255800;
                    lactitud = -83.863449;
                    break;
                case 5:
                    longitud = 10.429888;
                    lactitud = -84.748834;
                    break;
            }



            base.OnAppearing();
            var posicion = new Position(longitud, lactitud);

            Mapa.Pins.Add(new Pin { Label = "Estoy aqui", Position = posicion });

            var mapSpan = MapSpan.FromCenterAndRadius(posicion, Distance.FromMiles(0.5));

            Mapa.MoveToRegion(mapSpan);
        }
    }
}