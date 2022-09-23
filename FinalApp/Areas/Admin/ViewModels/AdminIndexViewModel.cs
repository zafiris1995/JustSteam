using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalApp.Areas.Admin.ViewModels
{
    public class AdminIndexViewModel
    {
        public IEnumerable<Game> Games { get; set; }
        public IEnumerable<string> AllGenres { get; set; }
        public IEnumerable<string> AllCompanies { get; set; }
    }
}