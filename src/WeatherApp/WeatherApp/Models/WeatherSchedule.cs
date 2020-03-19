using System;
using Xamarin.Forms;

namespace WeatherApp.Models
{
    public class WeatherSchedule
    {
        public string Time { get; set; }
        public int Hours { get; set; }
        public string Temparature { get; set; }
        public string Icon { get; set; }
        public Color IconColor { get; set; }
        public bool IsCurrentTime { get; set; }
    }
}
