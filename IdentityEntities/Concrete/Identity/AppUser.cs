﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityEntities.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Disrtict { get; set; }
        public string City { get; set; }
        public string ImagesUrl { get; set; }
        public List<CustomerAccount> CustomerAccount { get; set; }
    }
}
