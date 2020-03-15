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
        bool MoreLikeSectionIsOpen;
        double InitialYPosition;
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
            InitialYPosition = optionsContainer.Bounds.Y;

        }
        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {

            var element = optionsContainer;
            if (MoreLikeSectionIsOpen)
            {
                var newBounds = new Rectangle(element.Bounds.X, InitialYPosition, element.Bounds.Width, 80);
                element.LayoutTo(newBounds, 500, Easing.SpringOut);
                var parentAnimation = new Animation
                {
                    { 0, 1, new Animation(v => headerConatiner.HeightRequest = v, headerConatiner.HeightRequest, 100, Easing.SpringOut) }
                };
                parentAnimation.Commit(headerConatiner, "parentAnimationDown", 60, 500);
                //
                var btnCoon = new Animation
                {
                    { 0, 1, new Animation(v => btnContainer.HeightRequest = v, btnContainer.HeightRequest, 160, Easing.SpringOut) }
                };
                btnCoon.Commit(btnContainer, "btnCoonAnimationDown", 60, 500);

                //
                var titleCoon = new Animation
                {
                    { 0, 1, new Animation(v => title.FontSize = v,  title.FontSize,  Device.GetNamedSize (NamedSize.Title, typeof(Label)), Easing.SpringOut) }
                };
                titleCoon.Commit(title, "titleAnimationDown", 60, 500);
            }
            else
            {
                var newBounds = new Rectangle(element.Bounds.X, fraContainer.Bounds.Y, element.Bounds.Width, fraContainer.Bounds.Height);
                element.LayoutTo(newBounds, 500, Easing.SpringOut);
                var parentAnimation = new Animation
                {
                    { 0, 1, new Animation(v => headerConatiner.HeightRequest = v, headerConatiner.HeightRequest, 75, Easing.SpringOut) }
                };
                parentAnimation.Commit(headerConatiner, "parentAnimationDown", 60, 500);
                //
                var btnCoon = new Animation
                {
                    { 0, 1, new Animation(v => btnContainer.HeightRequest = v, btnContainer.HeightRequest, 80, Easing.SpringOut) }
                };
                btnCoon.Commit(btnContainer, "btnCoonAnimationDown", 60, 500);

                //
                var titleCoon = new Animation
                {
                    { 0, 1, new Animation(v => title.FontSize = v,  title.FontSize,  Device.GetNamedSize (NamedSize.Header, typeof(Label)), Easing.SpringOut) }
                };
                titleCoon.Commit(title, "titleAnimationDown", 60, 500);
            }
            MoreLikeSectionIsOpen = !MoreLikeSectionIsOpen;
            

        }

        void TapGestureRecognizer_Tapped_1(System.Object sender, System.EventArgs e)
        {
            var element = optContainer;
            if (MoreLikeSectionIsOpen)
            {
                var newBounds = new Rectangle(element.Bounds.X, InitialYPosition, element.Bounds.Width, 80);
                element.LayoutTo(newBounds, 500, Easing.SpringOut);
                var parentAnimation = new Animation
                {
                    { 0, 1, new Animation(v => headerConatiner.HeightRequest = v, headerConatiner.HeightRequest, 100, Easing.SpringOut) }
                };
                parentAnimation.Commit(headerConatiner, "parentAnimationDown", 60, 500);
                //
                var btnCoon = new Animation
                {
                    { 0, 1, new Animation(v => btnContainer.HeightRequest = v, btnContainer.HeightRequest, 160, Easing.SpringOut) }
                };
                btnCoon.Commit(btnContainer, "btnCoonAnimationDown", 60, 500);

                //
                var titleCoon = new Animation
                {
                    { 0, 1, new Animation(v => title.FontSize = v,  title.FontSize,  Device.GetNamedSize (NamedSize.Title, typeof(Label)), Easing.SpringOut) }
                };
                titleCoon.Commit(title, "titleAnimationDown", 60, 500);
            }
            else
            {
                var newBounds = new Rectangle(element.Bounds.X, fraContainer.Bounds.Y, element.Bounds.Width, fraContainer.Bounds.Height);
                element.LayoutTo(newBounds, 500, Easing.SpringOut);
                var parentAnimation = new Animation
                {
                    { 0, 1, new Animation(v => headerConatiner.HeightRequest = v, headerConatiner.HeightRequest, 75, Easing.SpringOut) }
                };
                parentAnimation.Commit(headerConatiner, "parentAnimationDown", 60, 500);
                //
                var btnCoon = new Animation
                {
                    { 0, 1, new Animation(v => btnContainer.HeightRequest = v, btnContainer.HeightRequest, 80, Easing.SpringOut) }
                };
                btnCoon.Commit(btnContainer, "btnCoonAnimationDown", 60, 500);

                //
                var titleCoon = new Animation
                {
                    { 0, 1, new Animation(v => title.FontSize = v,  title.FontSize,  Device.GetNamedSize (NamedSize.Header, typeof(Label)), Easing.SpringOut) }
                };
                titleCoon.Commit(title, "titleAnimationDown", 60, 500);
            }
            MoreLikeSectionIsOpen = !MoreLikeSectionIsOpen;
        }
    }
}
