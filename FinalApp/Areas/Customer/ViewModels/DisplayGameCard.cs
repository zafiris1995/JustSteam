using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalApp.Areas.Customer.ViewModels
{
    public class DisplayGameCard
    {
        public IEnumerable<Game> Games { get; set; }

        public string HeaderTitle { get; set; }

        
    }
}