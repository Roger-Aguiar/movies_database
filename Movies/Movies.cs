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

        private int Id{get; init;}
        private string OriginalTitle {get; init;}
        private string Title{get; init;}
        private DateTime Year{get; init;}
        private string ImdbLink{get; init;}
        private List<string> Actors {get; init;}
        private List<string> Genres{get; init;}
    }
}