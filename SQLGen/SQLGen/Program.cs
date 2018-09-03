using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity;

namespace SQLGen
{
    class Program
    {
        static void Main(string[] args)
        {
            //注入SQLGen拦截器
            DbInterception.Add(new SQLGenInterecptor());
            using (var context = new DataContext())
            {
                //Insert语句
                context.Users.Add(new User()
                {
                    UserName = "PayneQin",
                    UserRole = "Administrator"
                });

                context.SaveChanges();
            }
        }
    }
}
