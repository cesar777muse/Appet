using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appet
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class emailRegistration : ContentPage
    {
        public emailRegistration()
        {
            InitializeComponent();
        }

        private void Button_createAccount(object sender, EventArgs e)
        {

        }

        private async void Button_cancel(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new registrationLand());
        }
    }
}