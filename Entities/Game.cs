using System;
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
        [Display(Name = "Price")]
        public int Price { get; set; }
        [Display(Name = "Rating")]
        public int Rating { get; set; }
        //public string Description { get; set; }
        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Cover Photo")]
        public string PhotoUrl { get; set; }
        [Display(Name = "Trailer")]
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
