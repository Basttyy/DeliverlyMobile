using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deliverly.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Deliverly.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ForgotPasswordPage : ContentPage
    {
        public ForgotPasswordPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void OnSignupTapped(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}