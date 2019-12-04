using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IntexMVC.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace IntexMVC.Context
{
    public class ApplicationDataContext : IdentityDbContext<AppUser>
    {
        public ApplicationDataContext()
            : base("DefaultConnection")
        { }

        public System.Data.Entity.DbSet<AppUser> AppUsers { get; set; }

        public System.Data.Entity.DbSet<IntexMVC.Models.Credentials> Credentials { get; set; }
    }
}