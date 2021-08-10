using System;
using Xamarin.Forms;

namespace SfTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Calendar.NumberOfWeeksInView = Calendar.NumberOfWeeksInView == 1 ? 6 : 1;
            if (Calendar.NumberOfWeeksInView == 1)
            {
                Calendar.MoveToDate = Calendar.SelectedDate.Value;
                Calendar.NavigateTo(Calendar.SelectedDate.Value);
            }
        }
    }
}
