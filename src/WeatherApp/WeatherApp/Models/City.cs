using System;
using Xamarin.Forms;

namespace WeatherApp.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Temparute { get; set; }
        public string Time { get; set; }
        public string Icon { get; set; }
        public Color IconColor { get; set; }
    }
}
