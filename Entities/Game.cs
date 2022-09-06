using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }

        // Navigation Props

        public virtual ICollection<Genre> Genres { get; set; }
        public virtual Company Company { get; set; }
    }
}
