using Xamarin.Forms;
using XamarinFormsSvg.ViewModels;

namespace XamarinFormsSvg
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}
