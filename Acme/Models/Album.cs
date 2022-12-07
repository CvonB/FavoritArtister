namespace FavoritArtister.Models
{
    public class Album
    {
        public Album(int year, string name)
        {
            Year = year;
            Name = name;
        }

        public int Year { get; set; }
        public string Name { get; set; }

    }
}
