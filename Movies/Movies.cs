using System;
using System.Collections.Generic;

namespace MyMoviesDatabase.Movies
{
    public class Movies
    {        
        public Movies(int id)
        {
            Id = id;            
        }

        public Movies(string originalTitle, string title, DateTime year, string imdbLink, List<string> actors, List<string> genres)
        {
            OriginalTitle = originalTitle;
            Title = title;
            Year = year;
            ImdbLink = imdbLink;
            Actors = actors;
            Genres = genres;
        }

        public int Id{get; init;}
        public string OriginalTitle {get; init;}
        public string Title{get; init;}
        public DateTime Year{get; init;}
        public string ImdbLink{get; init;}
        public List<string> Actors {get; init;}
        public List<string> Genres{get; init;}
    }
}