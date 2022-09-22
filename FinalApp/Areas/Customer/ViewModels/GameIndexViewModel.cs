using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalApp.Areas.Customer.ViewModels
{
    public class GameIndexViewModel
    {
        public IEnumerable<Game> Games { get; set; }
       // public IEnumerable<Genre> Genres { get; set; }
        
        public IEnumerable<Game> GetBestGames { get; set; }
        public IEnumerable<Game> GetOldestGames { get; set; }
        public IEnumerable<Game> GetNewestGames { get; set; }
        public IEnumerable<Game> GetGamesByPriceAsc { get; set; }
        public IEnumerable<Game> GetGamesByPriceDesc { get; set; }
        public IEnumerable<string> AllGenres { get; set; }
        public IEnumerable<string> AllCompanies { get; set; }
    }
}