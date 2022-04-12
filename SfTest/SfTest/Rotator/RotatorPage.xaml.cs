
using SfTest.ViewModel;
using System.Collections.Generic;
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
            BindingContext = new RotatorViewModel();
        }
    }

    public class RotatorViewModel : BaseViewModel
    {
        private List<RotatorItemModel> items = new List<RotatorItemModel>();
        public List<RotatorItemModel> Items
        {
            get { return items; }
            set { items = value; NotifyPropertyChanged(); }
        }

        public RotatorViewModel()
        {
            Items = new List<RotatorItemModel>()
            {
                new RotatorItemModel()
                {
                    Name = "Name 0001"
                    , Description = "Description 0001"
                }
                ,new RotatorItemModel()
                {
                    Name = "Name 0002"
                    , Description = "Description 0002"
                }
                ,new RotatorItemModel()
                {
                    Name = "Name 0003"
                    , Description = "Description 0003"
                }
                ,new RotatorItemModel()
                {
                    Name = "Name 0004"
                    , Description = "Description 0004"
                }
            };
        }
    }

    public class RotatorItemModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}