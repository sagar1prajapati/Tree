using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Tree.Models;

namespace Tree.DataAccess
{
    public class TreeviewContext : DbContext
    {
        public TreeviewContext() : base("DefaultConnection")
        {

        }

        public DbSet<Categories> Categories { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}
    }
}