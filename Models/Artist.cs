using System;
using System.Collections.Generic;

namespace festival_m.Models
{
    public partial class Artist
    {
        public Artist()
        {
            Festivals = new HashSet<Festival>();
        }

        public int ArtistId { get; set; }
        public string ArtistName { get; set; } = null!;

        public virtual ICollection<Festival> Festivals { get; set; }
    }
}
