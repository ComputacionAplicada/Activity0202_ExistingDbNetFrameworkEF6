using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Activity01_NetFramework;

namespace Activity0202_ExistingDbNetFrameworkEF6
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AdventureWorksEntities())
            { 
                var people = db.People.OrderByDescending(x => x.LastName).Take(20);
                foreach(var person in people)
                { 
                    foreach(var p in people)
                    {
                        Console.WriteLine($"{p.FirstName} - {p.LastName}");
                    }
                }
            }
        }
    }
}
