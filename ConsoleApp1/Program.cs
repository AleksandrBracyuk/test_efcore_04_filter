using ConsoleApp1.Utils;
using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using(DbContext db = new DbContext())
            {
                //Test.ShowQuery(db.Countries);
                //Test.ShowQuery(db.Cities);
                //Test.ShowQuery(db.Mains);
                //Test.ShowQuery(db.Details);
                //Test.ShowQuery(db.DetailChilds);
                Console.WriteLine("=========================================");

                //Test.ShowQuery<Country>(db.Countries.Where(x=>x.Name.ToLower() == "usa" || x.Id<2));

                DocExample.GoDynamic();
            }



            Console.ReadLine();
        }
    }
}
