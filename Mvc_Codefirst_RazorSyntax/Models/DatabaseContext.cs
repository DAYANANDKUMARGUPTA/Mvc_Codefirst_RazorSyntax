using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mvc_Codefirst_RazorSyntax.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("daya")
        {

        }
        public DbSet<tblEmployee> tblEmployees { get; set; }
        public DbSet<tblcountry> tblcountries { get; set; }
        public DbSet<tblstate> tblstates { get; set; }
    }
}