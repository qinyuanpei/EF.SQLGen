using Microsoft.EntityFrameworkCore;
using SQLGen.Models;
using System;

namespace SQLGen
{
    public class DataContext: DbContext
    {
        public virtual DbSet<User> Users { get; set; }

        public DataContext :base("")
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserTypeMap());
        }
    }
}