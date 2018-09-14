using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using SQLGen.Models;
using System;

namespace SQLGen
{
    public class DataContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var loggerFactory = new LoggerFactory();
            loggerFactory.AddProvider(new SQLGenLoggerProvider());
            optionsBuilder.UseLoggerFactory(loggerFactory)
                .EnableSensitiveDataLogging()
                .UseSqlServer(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=SQLGen.DataContext;Integrated Security=True;MultipleActiveResultSets=True;App=EntityFramework"); 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserTypeMap());
            modelBuilder.Entity<User>().ToTable("Users");
        }
    }
}