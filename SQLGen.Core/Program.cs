using Microsoft.EntityFrameworkCore;
using SQLGen.Models;
using System;

namespace SQLGen
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DataContext())
            {
                context.Users.Add(new User()
                {
                    UserName = "PayneQin",
                    UserRole = "Developer"
                });

                context.SaveChanges();
            }
        }
    }
}
