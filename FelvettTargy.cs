using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanulmanyiRendszerUjra
{
    internal class FelvettTargy
    {
        string tKod, hKod;

        public FelvettTargy(string tKod, string hKod)
        {
            this.tKod = tKod;
            this.hKod = hKod;
        }

        public FelvettTargy()
        { }


        public string TKod { get => tKod; set => tKod = value; }
        public string HKod { get => hKod; set => hKod = value; }

        public override string ToString()
        {
            return TKod + "\t" + HKod;
        }
    }
}
