using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Studerende
    {
        public string Navn { get; set; }
        public int fødselsmåned { get; set; }
        public int fødselsdag { get; set; }

        public Studerende(string navn, int fødselsmåned, int fødselsdag)
        {
            if (fødselsmåned >= 1 || fødselsmåned <= 12)
            {
                Navn = navn;
                this.fødselsmåned = fødselsmåned;
                this.fødselsdag = fødselsdag;
            }
        }

        public string Årstid(int c)
        {
            switch (c)
            {
                case 12: case 1: case 2:
                {
                    return "Vinter";
                    break;
                }

                case 3:case 4: case 5:
                {
                    return "Forår";
                    break;
                }

                case 6: case 7: case 8:
                {
                    return "Sommer";
                    break;
                }

                case 9: case 10: case 11:
                {
                    return "Efterår";
                    break;
                }
            }
            return "Something went wrong Out of range";
        }
    }
}
