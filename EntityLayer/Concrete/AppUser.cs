﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        // zorunlu olmaması için ne yapabilirim

        public string ImageUrl { get; set; } = null; 
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
