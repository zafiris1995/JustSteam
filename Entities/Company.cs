using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set; }

        // Navigation Props
        public virtual ICollection<Game> Games { get; set; }

        
    }
}
