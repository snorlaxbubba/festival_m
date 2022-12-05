﻿using System;
using System.Collections.Generic;

namespace festival_m.Models
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }

        public string Email { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public bool Admin { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
