using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SfTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public static readonly BindableProperty MonthsListProperty =
        BindableProperty.Create("MonthsList", typeof(List<MonthData>), typeof(ListViewPage), new List<MonthData>());

        public List<MonthData> MonthsList
        {
            get => (List<MonthData>) GetValue(MonthsListProperty);
            set => SetValue(MonthsListProperty, value);
        }

        private readonly MonthData march = new MonthData() { Name = "March" };

        public ListViewPage()
        {
            InitializeComponent();
            MonthsList.Add(new MonthData() { Name = "January" });
            MonthsList.Add(new MonthData() { Name = "February" });
            MonthsList.Add(new MonthData() { Name = "March" });
            MonthsList.Add(new MonthData() { Name = "April" });
            MonthsList.Add(new MonthData() { Name = "May" });
            MonthsList.Add(new MonthData() { Name = "June" });
            MonthsList.Add(new MonthData() { Name = "July" });
            MonthsList.Add(new MonthData() { Name = "August" });
            MonthsList.Add(new MonthData() { Name = "September" });
            MonthsList.Add(new MonthData() { Name = "October" });
            MonthsList.Add(new MonthData() { Name = "November" });
            MonthsList.Add(new MonthData() { Name = "December" });

            MonthsList.Add(new MonthData() { Name = "January" });
            MonthsList.Add(new MonthData() { Name = "February" });
            MonthsList.Add(new MonthData() { Name = "March" });
            MonthsList.Add(new MonthData() { Name = "April" });
            MonthsList.Add(new MonthData() { Name = "May" });
            MonthsList.Add(new MonthData() { Name = "June" });
            MonthsList.Add(new MonthData() { Name = "July" });
            MonthsList.Add(new MonthData() { Name = "August" });
            MonthsList.Add(new MonthData() { Name = "September" });
            MonthsList.Add(new MonthData() { Name = "October" });
            MonthsList.Add(new MonthData() { Name = "November" });
            MonthsList.Add(new MonthData() { Name = "December" });

            MonthsList.Add(new MonthData() { Name = "January" });
            MonthsList.Add(new MonthData() { Name = "February" });
            MonthsList.Add(march);
            MonthsList.Add(new MonthData() { Name = "April" });
            MonthsList.Add(new MonthData() { Name = "May" });
            MonthsList.Add(new MonthData() { Name = "June" });
            MonthsList.Add(new MonthData() { Name = "July" });
            MonthsList.Add(new MonthData() { Name = "August" });
            MonthsList.Add(new MonthData() { Name = "September" });
            MonthsList.Add(new MonthData() { Name = "October" });
            MonthsList.Add(new MonthData() { Name = "November" });
            MonthsList.Add(new MonthData() { Name = "December" });

            MonthsList.Add(new MonthData() { Name = "January" });
            MonthsList.Add(new MonthData() { Name = "February" });
            MonthsList.Add(new MonthData() { Name = "March" });
            MonthsList.Add(new MonthData() { Name = "April" });
            MonthsList.Add(new MonthData() { Name = "May" });
            MonthsList.Add(new MonthData() { Name = "June" });
            MonthsList.Add(new MonthData() { Name = "July" });
            MonthsList.Add(new MonthData() { Name = "August" });
            MonthsList.Add(new MonthData() { Name = "September" });
            MonthsList.Add(new MonthData() { Name = "October" });
            MonthsList.Add(new MonthData() { Name = "November" });
            MonthsList.Add(new MonthData() { Name = "December" });
            MonthsList.Add(new MonthData() { Name = "December" });
        }

        protected override async void OnAppearing()
        {
            await Task.Delay(2000);
            ListOfMonths.ScrollTo(march, scrollToPosition: Syncfusion.ListView.XForms.ScrollToPosition.Start);
        }
    }

    public class MonthData
    {
        public string Name { get; set; }
    }
}