using Appet.Services;
using Appet.Views;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appet
{
    public partial class App : Application
    {
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            BindingContext = this;
            // MainPage = new AppShell();
            MainPage = new NavigationPage(new registrationLand());
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
