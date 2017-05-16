using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using MVC.Models;

namespace MVC.DAL
{
    public class MVCContext : DbContext
    {
        
        public DbSet<Student> Students { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            // modelBuilder.Entity<Student>().Property(u => u.StudentName).HasColumnName("Name");
        }
    }
}