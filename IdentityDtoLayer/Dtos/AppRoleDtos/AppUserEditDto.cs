﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityDtoLayer.Dtos.AppRoleDtos
{
	public  class AppUserEditDto
	{
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Password { get; set; }
        public string ConfirmPasswod { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string ImageUrl { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
