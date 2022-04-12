
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SfTest.Rotator
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RotatorPage : ContentPage
    {
        public RotatorPage()
        {
            InitializeComponent();
        }
    }

    public class ItemModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}