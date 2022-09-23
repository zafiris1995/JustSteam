﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Game
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "You gave no Title"), MaxLength(60),MinLength(2)]
        public string Title { get; set; }
        [Required(ErrorMessage = "You gave wrong Price"),]
        public int Price { get; set; }
        public int Rating { get; set; }
        //public string Description { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        public string PhotoUrl { get; set; }
        public string VideoUrl { get; set; }

        // Navigation Props
        public Game()
        {
            this.Genres = new HashSet<Genre>();
        }
        // Navigation Properties
        public virtual ICollection<Genre> Genres { get; set; }
        //public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
    }
}
