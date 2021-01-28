using Xamarin.Forms;
using XamExxen.Models;
using XamExxen.ViewModels;

namespace XamExxen.Views
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage(MovieBaseModel keepWatching)
        {
            InitializeComponent();
            BindingContext = new DetailPageViewModel(Navigation, keepWatching);
        }
    }
}
