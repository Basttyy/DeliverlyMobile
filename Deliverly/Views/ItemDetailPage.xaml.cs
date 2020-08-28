using System.ComponentModel;
using Xamarin.Forms;
using Deliverly.ViewModels;

namespace Deliverly.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}