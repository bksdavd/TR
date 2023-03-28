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
    public partial class TargyfelvetelForm : Form
    {
        Felhasznalo h;
        List<Targy> targyak = new List<Targy> ();
        List<FelvettTargy> felvettek = new List<FelvettTargy> () ;
        public TargyfelvetelForm(Felhasznalo f)
        {
            InitializeComponent();
            h = f;
            tbNev.Text = h.Nev + " (" + h.Kod + " )";
            FelvettTargyBeolvas();
            foreach (FelvettTargy t in felvettek)
            {
                if (t.HKod.ToString() == h.Kod.ToString())
                    lbFelvettek.Items.Add(t.TKod);
            }
            Targybeolvas();
            foreach (Targy t in targyak)
            {
                if (lbFelvettek.Items.Contains(t.TKod) == false)
                    lbTargyak.Items.Add(t.TKod); 
            }
        }

        private void FelvettTargyBeolvas()
        {
            if (File.Exists("FelvettTargyak.txt"))
            {
                StreamReader reader = new StreamReader("FelvettTargyak.txt");
                while (!reader.EndOfStream)
                {
                    FelvettTargy targy = new FelvettTargy();
                    string[] s = reader.ReadLine().Split('\t');
                    targy.TKod = s[0];
                    targy.HKod = s[1];
                    felvettek.Add(targy);
                }
                reader.Close();
            } 
        }

        private void Targybeolvas()
        {
            if (File.Exists("Targyak.txt"))
            {
                StreamReader reader = new StreamReader("Targyak.txt");
                while (!reader.EndOfStream)
                {
                    string [] s = reader.ReadLine().Split('\t');
                    Targy t = new Targy();
                    t.TNev = s[0];
                    t.TKod = s[1];
                    t.Kredit = Convert.ToInt32 (s[2]);
                    targyak.Add(t);
                    lbTargyak.Items.Add(t.TKod);
                }
                reader.Close();
            }
        }

        private void btnFelvetel_Click(object sender, EventArgs e)
        {
            if (lbTargyak.SelectedItem != null)
            {
                lbFelvettek.Items.Add(lbTargyak.SelectedItem.ToString());
                FelvettTargy felvesz = new FelvettTargy(lbTargyak.SelectedItem.ToString(), h.Kod);
                felvettek.Add(felvesz);
                lbTargyak.Items.Remove(lbTargyak.SelectedItem);
            }
            else
            {
                MessageBox.Show("Nem választott ki tárgyat !"); 
            }
        }

        private void btnLead_Click(object sender, EventArgs e)
        {
            if (lbFelvettek.SelectedItem != null)
            {
                lbTargyak.Items.Add(lbFelvettek.SelectedItem.ToString());
                FelvettTargy lead = felvettek.Find((FelvettTargy p) =>
                { return (p.TKod == lbFelvettek.SelectedItem.ToString() && p.HKod == h.Kod); });
                felvettek.Remove(lead);
                lbFelvettek.Items.Remove(lbFelvettek.SelectedItem);
            }
            else
            {
                MessageBox.Show("Nem választott ki tárgyat!");
            }
        }

        private void TargyfelvetelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter w = new StreamWriter("FelvettTargyak.txt");
            int i = 0;
            while (i < felvettek.Count)
            {
                FelvettTargy targy = new FelvettTargy();
                targy = felvettek[i];
                w.WriteLine(targy.ToString());
                i++;
            }
            w.Close();
        }
    }
}
