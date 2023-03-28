using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TanulmanyiRendszerUjra
{
    public partial class BejelentkezoForm : Form
    {
        List<Felhasznalo> felhasznalok = new List<Felhasznalo>();
        public BejelentkezoForm()
        {
            InitializeComponent();
            Beolvas();
        }

        private void Beolvas()
        {
            StreamReader reader = new StreamReader("Felhasznalok.txt"); //a txt fájlból fájlok átmásolása
            while (!reader.EndOfStream)
            {
                string [] s = reader.ReadLine().Split('\t');
                if (s.Length == 4)
                {
                    Felhasznalo f = new Felhasznalo();
                    f.Nev = s[0];
                    f.Kod = s[1];
                    f.Jelszo = s[2];
                    f.Sz = (Szerep)Enum.Parse(typeof(Szerep), s[3]);
                    felhasznalok.Add(f);
                }
                else
                {
                    Adminisztrator a = new Adminisztrator(s[0], s[1], s[2], (Szerep)Enum.Parse(typeof(Szerep), s[3]), Convert.ToBoolean(s[4]), Convert.ToBoolean(s[5]));
                    felhasznalok.Add(a);
                }
            }
            reader.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (rbH.Checked)
            {
                int i = 0;
                bool talal = false;
                while (i < felhasznalok.Count && !talal)
                {
                    if (tbKod.Text == felhasznalok[i].Kod && tbJelszo.Text == felhasznalok[i].Jelszo &&
                        felhasznalok[i].Sz == Szerep.Hallgato)
                    {
                        talal = true;
                    }
                    else
                    {
                        i++;
                    }
                }
                if (talal)
                {
                    TargyfelvetelForm uj = new TargyfelvetelForm(felhasznalok[i]);
                    uj.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Ezzel a kóddal és jelszóval nincsen hallgató!");
                }
            }
            else if(rbA.Checked)
            {
                int i = 0;
                bool talal = false;
                while (i < felhasznalok.Count && !talal)
                {
                    if (tbKod.Text == felhasznalok[i].Kod && tbJelszo.Text == felhasznalok[i].Jelszo && felhasznalok[i].Sz == Szerep.Adminisztrator)
                    {
                        talal = true;
                    }
                    else
                    {
                        i++;
                    }
                }
                if (talal)
                {
                    Adminisztrator a = felhasznalok[i] as Adminisztrator;
                    if (a.FelhasznaloJog || a.TargyJog)
                    {
                        AdmForm uj = new AdmForm(a);
                        uj.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Hiányzó jogosultságok!");
                    }
                }
                else
                {
                    MessageBox.Show("Ezzel a kóddal és jelszóval nincs adminisztrátor!");
                }
            }
            tbKod.Text = "";
            tbJelszo.Text = "";
            rbH.Checked = true;
        }
    }
}
