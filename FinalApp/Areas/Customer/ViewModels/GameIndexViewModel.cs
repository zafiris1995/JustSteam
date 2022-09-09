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
        public IEnumerable<Game> GetBestGames { get; set; }
    }
}