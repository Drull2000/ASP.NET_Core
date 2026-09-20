namespace Indep_20_09_26.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Author { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
    }

    public class BookModel
    {
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public int Pages { get; set; }
        public List<Review> Reviews { get; set; } = new();
    }
}