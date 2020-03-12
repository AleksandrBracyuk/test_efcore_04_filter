using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace ConsoleApp1.Utils
{
    static class Test
    {
        //public static void Show<T>(DbSet<T> table)
        //    where T : class
        //{
        //    var items = table.ToList();
        //    foreach (var item in items)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        public static void ShowQuery<T>(IQueryable<T> query)
        where T : class
        {
            var items = query.ToList();
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

       
    }
}
