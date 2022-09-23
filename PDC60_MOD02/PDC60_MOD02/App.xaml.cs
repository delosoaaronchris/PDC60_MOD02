using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC60_MOD02
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new View.PageView1());
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
