namespace FavoritArtister.Models
{
    public class Band
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Album> Albums { get; set; } = new List<Album>();
        public string Picture { get; set; }
    }

}
