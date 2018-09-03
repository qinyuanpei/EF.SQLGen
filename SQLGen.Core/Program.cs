using Microsoft.EntityFrameworkCore;
using System;

namespace SQLGen
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new DbContextOptions<DataContext>()
            {

            };

            using (var context = new DbContext())
            {

            }
        }
    }
}
