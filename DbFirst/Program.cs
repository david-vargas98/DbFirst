using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbContext =  new PlutoDbContext();

            //dbContext.funcGetAuthorCourses(1); // This doesn't follow C# conventions
            dbContext.GetAuthorCourses(1); // This follows C# conventions, much better
            var courses = dbContext.GetCourses();

            foreach (var course in courses)
            {
                Console.WriteLine($"Course: {course.Title}");
            }
        }
    }
}
