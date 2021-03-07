using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_1
{
    public class Tabella : IRigaCreatore
    {
        private List<Riga> righe = new List<Riga>();
        private static Tabella instanza { get; set; } = new Tabella();

        internal Tabella() { }

        public Tabella GetTabella()
        {
            if(instanza == null)
            {
                instanza = new Tabella();
            }
            return instanza;
        }
        public Riga CreatoreRiga()
        {
            Riga r = new Riga();
            righe.Add(r);
            return r;
        }

        public override string ToString()
        {
            string tabella = "<tabella>\n";
            foreach(Riga r in righe)
            {
                tabella = tabella + r.ToString();
            }
            return tabella + "\n<tabella>";
        }

        
    }
}
