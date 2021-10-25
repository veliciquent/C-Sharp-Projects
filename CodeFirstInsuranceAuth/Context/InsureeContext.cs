using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using CodeFirstInsuranceAuth.Models;

namespace CodeFirstInsuranceAuth.Context
{
    public class InsureeContext:DbContext
    {
        // The name of the connection string is passed into the constructor, and will be used in web.config file.

        public InsureeContext() : base("InsureeContextDB")
        {

        }

        public DbSet<Insuree> Insuree { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //base.OnModelCreating(modelBuilder);
        }
    }
}