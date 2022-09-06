using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string Kind { get; set; }

        // Navigation Props
        public virtual ICollection<Game> Games { get; set; }
    }
}
