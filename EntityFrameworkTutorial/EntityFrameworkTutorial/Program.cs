using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new UserContext())
            {
                var ilia = new User { Id = 1, Name = "Ilia Valchenko"};
                var arsenii = new User {Id = 2, Name = "Arsenii Valchenko"};

                db.Users.Add(ilia);
                db.Users.Add(arsenii);
                db.SaveChanges();

                Console.WriteLine("Get users from database:");
                foreach (var user in db.Users)
                {
                    Console.WriteLine("Id: {0}, Name: {1}", user.Id, user.Name);
                }
            }

            Console.WriteLine("\n\nTap to continue...");
            Console.ReadKey(true);
        }
    }
}
