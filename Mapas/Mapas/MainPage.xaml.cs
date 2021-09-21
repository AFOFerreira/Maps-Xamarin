using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Mapas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var mapa = new Map(MapSpan.FromCenterAndRadius(new Position(-22.342225010664198, -49.049339615448126),Distance.FromKilometers(1)));
            mapa.MapType = MapType.Street;

            var shopping = new Pin()
            {
                Position = new Position(-22.342225010664198, -49.049339615448126),
                Label = "Shopping"
            };
            mapa.Pins.Add(shopping);
            MapContainer.Children.Add(mapa);
        }
    }
}
