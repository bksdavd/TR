using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanulmanyiRendszerUjra
{
    public class Felhasznalo
    {
        string nev, kod, jelszo;
        Szerep sz;

        public Felhasznalo(string nev, string kod, string jelszo, Szerep sz)
        {
            this.nev = nev;
            this.kod = kod;
            this.jelszo = jelszo;
            this.sz = sz;
        }

        public Felhasznalo()
        { }

        public string Nev { get => nev; set => nev = value; }
        public string Kod { get => kod; set => kod = value; }
        public string Jelszo { get => jelszo; set => jelszo = value; }
        public Szerep Sz { get => sz; set => sz = value; }

        public override string ToString()
        {
            return nev + "\t" + kod + "\t" + jelszo + "\t" + sz;
        }
    }
    public enum Szerep { Hallgato, Oktato, Adminisztrator };
}
