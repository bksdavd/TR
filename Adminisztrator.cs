using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanulmanyiRendszerUjra
{
    public class Adminisztrator:Felhasznalo
    {
        bool targyJog, felhasznaloJog;

        public Adminisztrator(string nev, string kod, string jelszo, Szerep sz, bool targyJog, bool felhasznaloJog) :
            base (nev, kod, jelszo, sz)
        {
            this.targyJog = targyJog;
            this.felhasznaloJog = felhasznaloJog;
        }

        public Adminisztrator() { }

        public bool TargyJog { get => targyJog; set => targyJog = value; }
        public bool FelhasznaloJog { get => felhasznaloJog; set => felhasznaloJog = value; }

        public override string ToString()
        {
            return base.ToString() + "\t" + felhasznaloJog.ToString() + "\t" + targyJog.ToString();
        }
    }
}
