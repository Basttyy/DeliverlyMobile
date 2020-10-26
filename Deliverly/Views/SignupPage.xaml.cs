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
    public partial class SignupPage : ContentPage
    {
        public SignupPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }

        private void OnForgotPasswordTapped(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}