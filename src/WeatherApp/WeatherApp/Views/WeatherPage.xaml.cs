using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PancakeView;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace WeatherApp.Views
{
    public partial class WeatherPage : ContentPage
    {
        bool IsDetailSectionOpen;
        public WeatherPage()
        {
            Xamarin.Forms.NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            var safeInsets = On<iOS>().SafeAreaInsets();
            safeInsets.Bottom = 0;
            Padding = safeInsets;

        }
        void OnTodayDetailTapped(System.Object sender, System.EventArgs e)
        {
            //Open Today Section
            ToggleSection("today");
        }

        void OnWeekyDetailTapped(System.Object sender, System.EventArgs e)
        {
            //Toggle Cities Section
            ToggleSection("cities");
        }

        void ToggleSection(string section)
        {
            Animation parentAnimation;
            var element = section == "today" ? todayDetailSection : citiesDetailSection;

            if (IsDetailSectionOpen)
            {
                //Close Section
                var newBounds = new Rectangle(element.Bounds.X, (section == "today" ? citiesDetailSection : todayDetailSection).Bounds.Y, element.Bounds.Width, 80);
                element.LayoutTo(newBounds, 500, Easing.CubicInOut);

                //Animate Header to its initial State
                parentAnimation = new Animation
                {
                    { 0, 1, new Animation(v => headerConatiner.HeightRequest = v, headerConatiner.HeightRequest, 100, Easing.CubicInOut) },
                    { 0, 1, new Animation(v => btnContainer.HeightRequest = v, btnContainer.HeightRequest, 160, Easing.CubicInOut) },
                    { 0, 1, new Animation(v => title.FontSize = v,  title.FontSize,  Device.GetNamedSize (NamedSize.Title, typeof(Label)), Easing.CubicInOut) }
                };


                if (section == "today")
                {
                    citiesDetailBtn.FadeTo(1, 200, Easing.Linear);
                    todayChangesSection.FadeTo(0, 200, Easing.SinIn);
                    todayChangesSection.IsVisible = false;

                    temperatureSubTitle.FadeTo(1, 200, Easing.Linear);
                    parentAnimation.Add(0, 1, new Animation(v => temperatureTitle.FontSize = v, 40, 65, Easing.SpringOut));
                    parentAnimation.Add(0, 1, new Animation(v => temperatureTitle.TranslationX = v, temperatureTitle.X, 0, Easing.SpringOut));
                    parentAnimation.Add(0, 1, new Animation(v => temperatureIcon.FontSize = v, 40, Device.GetNamedSize(NamedSize.Title, typeof(Label)), Easing.CubicInOut));
                    parentAnimation.Add(0, 1, new Animation(v => temperatureIcon.TranslationY = v, temperatureIcon.Y, 0, Easing.SpringOut));
                }
                else
                {
                    temperatureSection.FadeTo(1, 200, Easing.Linear);
                    todayDetailBtn.FadeTo(1, 200, Easing.Linear);
                    sunSection.FadeTo(0, 200, Easing.Linear);

                    parentAnimation.Add(0, 1, new Animation(v => plusIcon.Scale = homeIcon.Opacity = v , 1, 0, Easing.SpringIn, () => {
                        todayDetailBtn.IsVisible = true;
                        todayDetailBtn.FadeTo(1, 200, Easing.Linear);
                    }));
                }
            }
            else
            {
                //Open Toggle Section
                var newBounds = new Rectangle(element.Bounds.X, detailContainer.Bounds.Y, element.Bounds.Width, detailContainer.Bounds.Height);
                element.LayoutTo(newBounds, 600, Easing.SpringOut);

                //Animate Header to its new State
                parentAnimation = new Animation
                {
                    { 0, 1, new Animation(v => headerConatiner.HeightRequest = v, headerConatiner.HeightRequest, 75, Easing.SpringOut) },
                    { 0, 1, new Animation(v => btnContainer.HeightRequest = v, btnContainer.HeightRequest, 80, Easing.SpringOut) },
                    { 0, 1, new Animation(v => title.FontSize = v,  title.FontSize,  Device.GetNamedSize (NamedSize.Large, typeof(Label)), Easing.CubicInOut) }
                };

                if (section == "today")
                {
                    citiesDetailBtn.FadeTo(0, 200, Easing.SinIn);
                    todayChangesSection.IsVisible = true;
                    todayChangesSection.FadeTo(1, 200, Easing.SinIn);
                    temperatureSubTitle.FadeTo(0, 200, Easing.SinIn);
                    parentAnimation.Add(0, 1, new Animation(v => temperatureTitle.FontSize = v, 65, 40, Easing.CubicInOut));
                    parentAnimation.Add(0, 1, new Animation(v => temperatureTitle.TranslationX = v, temperatureTitle.X, 50, Easing.CubicInOut));

                    parentAnimation.Add(0, 1, new Animation(v => temperatureIcon.FontSize = v, Device.GetNamedSize(NamedSize.Title, typeof(Label)), 40, Easing.CubicInOut));
                    parentAnimation.Add(0, 1, new Animation(v => temperatureIcon.TranslationY = v, temperatureIcon.Y, -70, Easing.CubicInOut));
                }
                else
                {
                    temperatureSection.FadeTo(0, 200, Easing.SinIn);
                    sunSection.FadeTo(1, 200, Easing.Linear);
                    parentAnimation.Add(0, 1, new Animation(v => todayDetailBtn.Opacity = v, 1, 0, Easing.Linear, () => {
                        todayDetailBtn.IsVisible = false;
                        homeIcon.FadeTo(1, 150, Easing.Linear);
                        plusIcon.ScaleTo(1, 300, Easing.CubicInOut);
                    }));
                }

            }
            parentAnimation.Commit(this, "parentAnimation", 12, 500);

            IsDetailSectionOpen = !IsDetailSectionOpen;
        }
    }
}
