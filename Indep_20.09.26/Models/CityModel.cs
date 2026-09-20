namespace Indep_20_09_26.Models
{
    public class Sight
    {
        public string Title { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
    }

    public class CityModel
    {
        public string Name { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public int FoundationYear { get; set; }
        public string Description { get; set; } = string.Empty;
        public List<Sight> Sights { get; set; } = new();
    }
}