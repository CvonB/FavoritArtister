namespace FavoritArtister.Models
{
    public class BandService
    {
        static int id = 0;
        private List<Band> bandList = new List<Band>()
        {
            new Band{ ID = id++, Name = "Pink Floyd", Description = "Mindre coolt rock band" },
            new Band{ ID = id++, Name = "Rammstein", Description = "Rätt så coolt rock band" },
            new Band{ ID = id++, Name = "Iron Maiden", Description = "Väldigt coolt rock band" }
       };

        public Band GetBandByID(int bandId)
        {
            return bandList[bandId];
        }

        public Band[] GetAllBands()
        {
            return bandList
                .ToArray();
        }
    }
}
