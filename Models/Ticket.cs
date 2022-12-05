﻿using System;
using System.Collections.Generic;

namespace festival_m.Models
{
    public partial class Ticket
    {
        public int TicketId { get; set; }
        public int OrderId { get; set; }
        public int FestivalId { get; set; }
        public int TicketTypeId { get; set; }

        public virtual Festival Festival { get; set; } = null!;
        public virtual Order Order { get; set; } = null!;
        public virtual TicketType TicketType { get; set; } = null!;
    }
}
