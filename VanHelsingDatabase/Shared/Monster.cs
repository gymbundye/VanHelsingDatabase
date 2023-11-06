using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanHelsingDatabase.Shared
{
    public class Monster
    {
        public int Id { get; set; } 

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;
        
        public string Alias { get; set; } = string.Empty;

        public Location? Location { get; set; }

        public int LocationId { get; set; }
    }
}
