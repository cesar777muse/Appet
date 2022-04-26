using Appet.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Appet.Views
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