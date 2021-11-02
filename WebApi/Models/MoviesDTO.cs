namespace WebApi.Models
{
    public class MoviesDTO
    {
        // Id must match Id field in DB
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
    }
}
