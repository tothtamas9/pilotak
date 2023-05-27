using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilotak
{
    public class PilotakAdatai
    {
        string nev;
        DateTime szuletesi_datum;
        string nemzetiseg;
        int rajtszam;

        public PilotakAdatai(string nev, DateTime szuletesi_datum, string nemzetiseg, int rajtszam)
        {
            this.nev = nev;
            this.szuletesi_datum = szuletesi_datum;
            this.nemzetiseg = nemzetiseg;
            this.rajtszam = rajtszam;
        }

        public string Nev { get => nev; }
        public DateTime Szuletesi_datum { get => szuletesi_datum; }
        public string Nemzetiseg { get => nemzetiseg; }
        public int Rajtszam { get => rajtszam; }
    }
}
