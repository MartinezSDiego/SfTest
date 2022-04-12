using Syncfusion.SfCalendar.XForms;
using System;
using Xamarin.Forms;

namespace SfTest.Calendar
{
    public partial class CalendarPage : ContentPage
    {
        public CalendarPage()
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
            else
            {
                DateTime newDate = new DateTime(Calendar.SelectedDate.Value.Year, Calendar.SelectedDate.Value.Month, 1, 0, 0, 0);
                Calendar.MoveToDate = newDate;
                Calendar.NavigateTo(newDate);
            }
        }

        private void Calendar_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (sender is SfCalendar calendar)
            {
                if (e.PropertyName == nameof(calendar.NumberOfWeeksInView))
                {
                    System.Diagnostics.Debug.WriteLine($"Number of weeks: {calendar.NumberOfWeeksInView}");
                }
                else if (e.PropertyName == nameof(calendar.VisibleDates))
                {
                    System.Diagnostics.Debug.WriteLine($"Number of visible dates: {calendar.VisibleDates.Count}");
                    foreach (DateTime visibleDate in calendar.VisibleDates)
                    {
                        System.Diagnostics.Debug.WriteLine($"Date: {visibleDate:yyyy-MMM-dd}");
                    }
                }
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            _ = DisplayAlert("Today date from the system", $"{DateTime.Now:yyyy-MMM-dd}", "OK", "Cancel");
        }

        private void Calendar_SelectionChanged(object sender, Syncfusion.SfCalendar.XForms.SelectionChangedEventArgs e)
        {
            //Calendar.MoveToDate = Calendar.SelectedDate.Value;
            Calendar.NavigateTo(Calendar.SelectedDate.Value);
        }
    }
}
