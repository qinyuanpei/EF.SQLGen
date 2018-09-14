using Microsoft.EntityFrameworkCore;
using SQLGen.Models;
using System;

namespace SQLGen
{
    public class DataContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\admin\Documents\SQLGen.Core.DataContext.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserTypeMap());
            modelBuilder.Entity<User>().ToTable("Users");
        }
    }
}