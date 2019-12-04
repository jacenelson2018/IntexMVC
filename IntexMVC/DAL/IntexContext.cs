using IntexMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IntexMVC.DAL
{
    public class IntexContext : DbContext
    {

        public IntexContext() : base("IntexContext")
        {

        }

        public DbSet<Customers> Customers { get; set; }
        public DbSet<WorkOrders> WorkOrder { get; set; }

        
    }
}