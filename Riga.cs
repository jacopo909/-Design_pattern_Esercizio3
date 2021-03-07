using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_1
{
    public class Riga
    {
        private List<Cella> celle = new List<Cella>();
        public Riga() { }

        public Cella CreaCella()
        {
            Cella c = new Cella();
            celle.Add(c);
            return c;
        }
        public override string ToString()
        {
            string riga = "<td>\n";
            foreach (Cella c in celle)
            {
                riga = riga + "testo scritto...";
            }
            return riga + "\n<td>";
        }

    }
}
