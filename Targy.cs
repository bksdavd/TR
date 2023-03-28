using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanulmanyiRendszerUjra
{
    internal class Targy
    {
        string tNev, tKod;
        int kredit;

        public Targy(string tNev, string tKod, int kredit)
        {
            this.tNev = tNev;
            this.tKod = tKod;
            this.kredit = kredit;
        }

        public Targy()
        {}

        public string TNev { get => tNev; set => tNev = value; }
        public string TKod { get => tKod; set => tKod = value; }
        public int Kredit { get => kredit; set { if (value < 0) { kredit = 0; } else if (value > 10) { kredit = 10; } else { kredit = value; } } }

        public override string ToString()
        {
            return tNev + "\t" + TKod + "\t" + kredit;
        }
    }
}
