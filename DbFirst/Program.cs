using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst
{
    public enum Level
    {
        Begginer = 1,
        Intermideate = 2,
        Advanced = 3
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var course = new Course();
            //course.Level = CourseLevel.Begginer; // enum from our data model: much better than using a magic number
            course.Level = Level.Begginer; // enum we created ourselves which is referenced to the data model enum
        }
    }
}
