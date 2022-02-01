using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SfTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CalendarPage();
            //MainPage = new ListViewPage();
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
