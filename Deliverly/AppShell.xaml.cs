using System;
using System.Collections.Generic;
using Deliverly.ViewModels;
using Deliverly.Views;
using Xamarin.Forms;

namespace Deliverly
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(TasksPage), typeof(TasksPage));
            Routing.RegisterRoute(nameof(NewTaskPage), typeof(NewTaskPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
