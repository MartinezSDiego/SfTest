using SfTest.Calendar;
using SfTest.List;
using SfTest.Rotator;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SfTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardPage : ContentPage
    {
        public DashboardPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CalendarPage());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RotatorPage());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListViewPage());
        }
    }
}