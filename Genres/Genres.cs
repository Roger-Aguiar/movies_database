namespace MyMoviesDatabase.Genres
{
    public class Genres
    {
        public Genres(int id)
        {
            Id = id;            
        }

        public Genres(string genre)
        {
            Genre = genre;
        }

        private int Id{get; init;}
        private string Genre{get; init;}
    }
}