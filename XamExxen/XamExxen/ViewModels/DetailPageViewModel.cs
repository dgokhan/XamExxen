using System.Collections.ObjectModel;
using Xamarin.Forms;
using XamExxen.Models;

namespace XamExxen.ViewModels
{
    public class DetailPageViewModel : BaseViewModel
    {
        public DetailPageViewModel(INavigation navigation, MovieBaseModel movieBaseModel)
        {
            Navigation = navigation;
            MovieBaseModel = movieBaseModel;
            Casts = MovieBaseModel.Cast;

        }

        public MovieBaseModel MovieBaseModel { get; set; }
        public ObservableCollection<Cast> Casts { get; set; }
    }
}
