using Xamarin.Forms;
using XamExxen.ViewModels;

namespace XamExxen.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = new MainPageViewModel(Navigation);
        } 
    }
}
