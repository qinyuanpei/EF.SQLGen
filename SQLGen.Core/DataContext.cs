using Microsoft.EntityFrameworkCore;
using SQLGen.Models;
using System;

namespace SQLGen
{
    public class DataContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserTypeMap());
        }
    }
}