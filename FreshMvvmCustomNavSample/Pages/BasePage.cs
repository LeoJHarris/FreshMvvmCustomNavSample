﻿using System;
using Xamarin.Forms;

namespace FreshMvvmCustomNavSample
{
    public class BasePage : ContentPage
    {
        public BasePage ()
        {
            ToolbarItems.Add (new ToolbarItem ("Main Menu", null, () => {
                Application.Current.MainPage = new NavigationPage (new LaunchPage ((App)Application.Current));
            }));
        }
    }
}

