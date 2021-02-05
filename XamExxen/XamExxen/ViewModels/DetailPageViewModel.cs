using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamExxen.Models;
using XamExxen.Views;

namespace XamExxen.ViewModels
{
    public class DetailPageViewModel : BaseViewModel
    {
        public DetailPageViewModel(INavigation navigation, MovieBaseModel movieBaseModel)
        {
            Navigation = navigation;
            MovieBaseModel = movieBaseModel;
            Casts = MovieBaseModel.Cast;

            BackToMainpage = new Command(async () => await ExecuteGoToMainpageCommand());
        }

        public Command BackToMainpage { get; }
        
        public MovieBaseModel MovieBaseModel { get; set; }
        public ObservableCollection<Cast> Casts { get; set; }

        private async Task ExecuteGoToMainpageCommand()
        {
            await Navigation.PopToRootAsync();
        }
    }
}
