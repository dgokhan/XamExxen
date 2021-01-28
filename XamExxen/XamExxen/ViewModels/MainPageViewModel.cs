using Plugin.SharedTransitions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamExxen.Models;
using XamExxen.Service;
using XamExxen.Views;

namespace XamExxen.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            KeepWatchings = new ObservableCollection<KeepWatching>();
            EditorsRecommendations = new ObservableCollection<EditorsRecommendation>();

            SelectSeriesCommand = new Command<KeepWatching>(async (param) => await ExecuteNavigateToDetailPageCommand(param));
            SelectRecSeriesCommand = new Command<EditorsRecommendation>(async (param) => await ExecuteNavigateToRecDetailPageCommand(param));
            GoToInfoPageCommand = new Command(async () => await ExecuteGoToInfoPageCommand());
            GoToHomePageCommand = new Command(async () => await ExecuteGoToHomePageCommand());
             
            GetKeepWatchings();
            GetEditorsRecommendations();
        }

        public Command SelectSeriesCommand { get; }
        public Command SelectRecSeriesCommand { get; }
        public Command GoToInfoPageCommand { get; }
        public Command GoToHomePageCommand { get; }
        public ObservableCollection<KeepWatching> KeepWatchings { get; set; }
        public ObservableCollection<EditorsRecommendation> EditorsRecommendations { get; set; }

        void GetEditorsRecommendations()
        {
            EditorsRecommendations = new ObservableCollection<EditorsRecommendation>(DataService.GetEditorsRecommendations());
        }

        void GetKeepWatchings()
        {
            KeepWatchings = new ObservableCollection<KeepWatching>(DataService.GetKeepWatching());
        }

        private async Task ExecuteGoToHomePageCommand()
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async Task ExecuteGoToInfoPageCommand()
        {
            await Navigation.PushAsync(new InfoPage());
        }

        private async Task ExecuteNavigateToDetailPageCommand(KeepWatching keepWatching)
        {
            var page = (App.Current.MainPage as SharedTransitionNavigationPage).CurrentPage;
            SharedTransitionNavigationPage.SetTransitionSelectedGroup(page, keepWatching.Id.ToString());
            await Navigation.PushAsync(new DetailPage(keepWatching));
        }

        private async Task ExecuteNavigateToRecDetailPageCommand(EditorsRecommendation editorsRecommendation)
        {
            var page = (App.Current.MainPage as SharedTransitionNavigationPage).CurrentPage;
            SharedTransitionNavigationPage.SetTransitionSelectedGroup(page, editorsRecommendation.Id.ToString());
            await Navigation.PushAsync(new DetailPage(editorsRecommendation));
        }
    }
}
