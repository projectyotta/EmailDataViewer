using arihant.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace arihant.DAL
{
    public class arihantcontext : DbContext
    {
        public arihantcontext()
            : base("arihantcontext")
        { }
        public DbSet<mail> mails { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}


        
    
