using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.EntityModels
{
    public class Account : IdentityUser
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
       
    }
}
