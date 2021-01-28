namespace XamExxen.Models
{
    public class KeepWatching : MovieBaseModel
    {
        public int SeasonNumber { get; set; }
        public int EpisodeNumber { get; set; }
        public int PercentageOfWatch { get; set; }
        public string ActiveEpAndSeaNumber
        {
            get
            {
                return $"S:{SeasonNumber}B:{EpisodeNumber}";
            }
        }
    }
}
