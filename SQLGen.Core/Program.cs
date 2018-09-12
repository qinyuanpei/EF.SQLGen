using Microsoft.EntityFrameworkCore;
using SQLGen.Models;
using System;

namespace SQLGen
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new DbContextOptionsBuilder<DbContext>()
                .UseSqlServer(@"Server=.;Database=Test1;Trusted_Connection=True;")
                .Options;
            using (var context = new DbContext(options))
            {
                context.Set<User>().Add(new User()
                {
                    UserName = "PayneQin",
                    UserRole = "Developer"
                });

                context.SaveChanges();
            }
        }
    }
}
