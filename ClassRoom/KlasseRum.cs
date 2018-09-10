using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class KlasseRum
    {
        public string KlasseNavn { get; set; }
        public List<Studerende> Klasseliste { get; set; }
        public DateTime SemesterStart { get; set; }

        public KlasseRum(string klasseNavn, List<Studerende> klasseliste, DateTime semesterStart)
        {
            KlasseNavn = klasseNavn;
            Klasseliste = klasseliste;
            SemesterStart = semesterStart;
        }

        public void CountSeasons()
        {
            int vinter = 0;
            int forår = 0;
            int sommer = 0;
            int efterår = 0;
            foreach (var Student in Klasseliste)
            {
                switch (Student.Årstid(Student.fødselsmåned))
                {
                    case "Vinter":
                    {
                        vinter++;
                        break;
                    }
                    case "Forår":
                    {
                        forår++;
                        break;
                    }
                    case "Sommer":
                    {
                        sommer++;
                        break;
                    }
                    case "Efterår":
                    {
                        efterår++;
                        break;
                    }
                }
            }
            Console.WriteLine("Fødselsdage i de forskellige sæsoner");
            Console.WriteLine("Vinter = " + vinter);
            Console.WriteLine("Forår = " + forår);
            Console.WriteLine("Sommer = " + sommer);
            Console.WriteLine("Efterår = " + efterår);
        }

        public override string ToString()
        {
            return $"{nameof(Klasseliste)}: {Klasseliste}, {nameof(KlasseNavn)}: {KlasseNavn}, {nameof(SemesterStart)}: {SemesterStart}";
        }
    }
}
