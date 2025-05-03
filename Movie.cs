namespace modul10_103022300037
{
    public class Movie
    {
        public string title { get; set; }
        public string director { get; set; }
        public List<string> stars { get; set; } 
        public string description { get; set; }

        public Movie(string title, string director, List<string> stars, string descriptions)
        {
            this.title = title;
            this.director = director;
            this.stars = stars;
            this.description = descriptions;
        }

    }
}
