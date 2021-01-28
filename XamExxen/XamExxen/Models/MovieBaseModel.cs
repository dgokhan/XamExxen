using System.Collections.ObjectModel;

namespace XamExxen.Models
{
    public class MovieBaseModel
    {
        public int Id { get; set; }
        public string SeriesName { get; set; }
        public string SeriesImage { get; set; }
        public string SeriesGenre { get; set; }
        public string SeriesYear { get; set; }
        public string SeriesDescription { get; set; }
        public ObservableCollection<Cast> Cast { get; set; }
    }
}
