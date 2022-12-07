namespace FavoritArtister.Models
{
    public class BandService
    {
        static int id = 0;
        private List<Band> bandList = new List<Band>()
        {
            new Band{ ID = id++, Name = "Pink Floyd", Description = "Mindre coolt rock band" },
            new Band{ ID = id++, Name = "Rammstein", Description = "Rätt så coolt rock band" },
            new Band{ ID = id++, Name = "Iron Maiden", Description = "Väldigt coolt rock band",Picture = "iron01.jpg",
                Albums = new List<Album>
                {
                    new Album(1980,"Iron Maiden"),
                    new Album(1981,"Killers"),
                    new Album(1982,"The Number of the Beast"),
                    new Album(1983,"Piece of Mind"),
                    new Album(1984,"Powerslave"),
                    new Album(1986,"Iron Maiden"),
                    new Album(1988,"Seventh Son of a Seventh Son"),
                    new Album(1990,"No Prayer For The Dying"),
                    new Album(1992,"Fear of the Dark"),
                    new Album(1995,"The X Factor"),
                    new Album(1998,"Virtual XI"),
                    new Album(2000,"Brave New World"),
                    new Album(2003,"Dance of Death"),
                    new Album(2006,"A Matter of Life and Death"),
                    new Album(2010,"The Final Frontier"),
                    new Album(2015,"The Book of Souls   Parlophone"),
                    new Album(2021,"Senjutsu")
                }
    }
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
