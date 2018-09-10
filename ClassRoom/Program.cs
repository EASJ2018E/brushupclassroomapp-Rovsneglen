using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Studerende> students = new List<Studerende>();
            students.Add(new Studerende("Patrick", 2, 1));
            students.Add(new Studerende("Steffen", 6, 13));
            var klasse = new KlasseRum("3B", students, DateTime.Parse("4-9-2018"));

            Console.WriteLine(klasse.ToString());
            klasse.CountSeasons();
        }
    }
}
