namespace MyRapidApiProject.Models
{
    public class ApiMovieViewModel
    {
        public string id { get; set; }
        public string url { get; set; }
        public string title { get; set; }
        public string primaryImage { get; set; }
        public string description { get; set; }
        public int startYear { get; set; }
        public object endYear { get; set; }
        public int runtimeMinutes { get; set; }
        public string contentRating { get; set; }
        public float averageRating { get; set; }
        public int numVotes { get; set; }
        public string type { get; set; }
    }
}
