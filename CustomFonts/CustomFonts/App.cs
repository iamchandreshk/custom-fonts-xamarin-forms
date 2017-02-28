using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CustomFonts
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            var content = new ContentPage
            {
                Title = "CustomFonts",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Lato Fonts",
                            FontFamily = Device.OnPlatform(
                                null,
                                "Lato-Regular.ttf#Lato-Regular",
                                "Assets/Lato-Regular.ttf#Lato-Regular")
                        },
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Sansita-Regular!",
                            FontFamily = Device.OnPlatform(
                                null,
                                "Sansita-Regular.ttf#Sansita-Regular",
                                "Assets/Sansita-Regular.ttf#Sansita-Regular")
                        },
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "IndieFlower!",
                            FontFamily = Device.OnPlatform(
                                null,
                                "IndieFlower.ttf#IndieFlower",
                                "Assets/IndieFlower.ttf#IndieFlower")
                        }
                    }
                }
            };

            MainPage = new NavigationPage(content);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
