﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Deliverly.Services;
using Deliverly.Views;

namespace Deliverly
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
