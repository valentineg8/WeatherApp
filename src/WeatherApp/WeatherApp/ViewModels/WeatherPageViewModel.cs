using System;
using System.Collections.ObjectModel;
using Prism.Mvvm;
using WeatherApp.Models;
using WeatherApp.Utils;
using Xamarin.Forms;

namespace WeatherApp.ViewModels
{
    public class WeatherPageViewModel : BindableBase
    {
        public ObservableCollection<City> Cities { get; set; }
        public ObservableCollection<WeatherSchedule> WeatherSchedule { get; set; }
        public ObservableCollection<WeatherSchedule> WeatherScheduleIcon { get; set; }
        public WeatherPageViewModel()
        {
            Cities = new ObservableCollection<City>
            {
                new City
                {
                    Id = 1,
                    Name = "Naples",
                    Temparute = "22°",
                    Time = "11:25",
                    Icon = MaterialDesignIcons.WeatherPouring,
                    IconColor = Color.FromHex("#773ad8")
                },
                new City
                {
                    Id = 2,
                    Name = "Lodon",
                    Temparute = "24°",
                    Time = "10:25",
                    Icon = MaterialDesignIcons.WeatherPartlyCloudy,
                    IconColor = Color.FromHex("#773ad8")
                },
                new City
                {
                    Id = 1,
                    Name = "Paris",
                    Temparute = "27°",
                    Time = "11:25",
                    Icon = MaterialDesignIcons.WeatherSunny,
                    IconColor = Color.FromHex("#fed262")
                },
                new City
                {
                    Id = 1,
                    Name = "Brussels",
                    Temparute = "21°",
                    Time = "11:25",
                    Icon = MaterialDesignIcons.WeatherPouring,
                    IconColor = Color.FromHex("#773ad8")
                }
            };

            WeatherSchedule = new ObservableCollection<WeatherSchedule>
            {
                new WeatherSchedule
                {
                    Time = "9:00",
                    Icon = MaterialDesignIcons.WeatherPouring,
                    Temparature = "18°"
                },
                new WeatherSchedule
                {
                    Time = "10:00",
                    Icon = MaterialDesignIcons.WeatherPouring,
                    Temparature = "19°"
                },
                new WeatherSchedule
                {
                    Time = "11:00",
                    Icon = MaterialDesignIcons.WeatherPouring,
                    IsCurrentTime = true,
                    Temparature = "19°"
                },
                new WeatherSchedule
                {
                    Time = "12:00",
                    Icon = MaterialDesignIcons.WeatherCloudy,
                    Temparature = "18°"
                },
                new WeatherSchedule
                {
                    Time = "13:00",
                    Icon = MaterialDesignIcons.WeatherPartlyCloudy,
                    Temparature = "18°"
                },
                new WeatherSchedule
                {
                    Time = "14:00",
                    Icon = MaterialDesignIcons.WeatherSunny,
                    Temparature = "18°"
                },
                new WeatherSchedule
                {
                    Time = "15:00",
                    Icon = MaterialDesignIcons.WeatherSunny,
                    Temparature = "18°"
                },
                new WeatherSchedule
                {
                    Time = "16:00",
                    Icon = MaterialDesignIcons.WeatherPartlyCloudy,
                    Temparature = "18°"
                }
            };

            WeatherScheduleIcon = new ObservableCollection<WeatherSchedule>
            {
                new WeatherSchedule
                {
                    Icon = "woman_raining",
                    IconColor = Color.FromHex("#773ad8"),
                    Hours = 4
                },
                new WeatherSchedule
                {
                    Icon = "walking_dog",
                    IconColor = Color.FromHex("#fed262"),
                    Hours = 4
                }
            };

        }
    }
}
