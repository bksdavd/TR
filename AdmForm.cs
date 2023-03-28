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
    public partial class AdmForm : Form
    {
        Adminisztrator adm;
        List<Targy> targyak = new List<Targy>();
        List<Targy> ujTargyak = new List<Targy>();
        List<Felhasznalo> ujFelhasznalok = new List<Felhasznalo>();
        List<Felhasznalo> felhasznalok = new List<Felhasznalo>();
        public AdmForm(Adminisztrator a)
        {
            InitializeComponent();
            adm = a;
            tbBelepve.Text = adm.Nev + " (" + adm.Kod + ") ";
            if (adm.FelhasznaloJog)
            {
                FBeolvas();
            }
            if (adm.TargyJog)
            {
                TBeolvas();
            }
        }

        private void FBeolvas()
        {
            if (File.Exists("Felhasznalok.txt"))
            {
                StreamReader reader = new StreamReader("Felhasznalok.txt");
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
        }

        private void TBeolvas()
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
                    t.Kredit = Convert.ToInt32(s[2]);
                    targyak.Add(t);
                }
                reader.Close();
            }
        }

        private void rbTargy_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = !groupBox1.Visible;
            groupBox2.Visible = !groupBox2.Visible;
        }

        private void AdmForm_Load(object sender, EventArgs e)
        {
            if (!adm.TargyJog)
            {
                rbTargy.Enabled = false;
                rbFelhasznalo.Checked = true;
            }
            if (adm.FelhasznaloJog)
            {
                rbFelhasznalo.Enabled = false;
            }
        }

        private void btnTMent_Click(object sender, EventArgs e)
        {
            if (tbTNev.Text != "" && tbTKod.Text != "")
            {
                int i = 0;
                bool talal = false;
                while (i < targyak.Count && !talal)
                {
                    if (tbTKod.Text == targyak[i].TKod)
                    {
                        talal = true;
                    }
                    else
                    {
                        i++;
                    }
                }
                if (i >= targyak.Count)
                {
                    Targy t = new Targy(tbTNev.Text, tbTKod.Text, Convert.ToInt32(nudKredit.Value));
                    targyak.Add(t);
                    ujTargyak.Add(t);
                }
                else
                {
                    MessageBox.Show("Már van ilyen kódú tárgy !");
                }
            }
            else
            {
                MessageBox.Show("Hiányzó adatok !");
            }
            tbTNev.Text = "";
            tbTKod.Text = "";
            nudKredit.Value = 0;
        }

        private void btnHMent_Click(object sender, EventArgs e)
        {
            if (tbFNev.Text != "" && tbFKod.Text != "" && tbJelszo.Text != "")
            {
                int i = 0;
                bool talal = false;
                while (i < felhasznalok.Count && !talal)
                {
                    if (tbFKod.Text == felhasznalok[i].Kod)
                    {
                        talal = true;
                    }
                    else
                    {
                        i++;
                    }
                }
                if (i >= felhasznalok.Count)
                {
                    if (cobSzerep.SelectedIndex == 2)
                    {
                        Adminisztrator a = new Adminisztrator(tbFNev.Text, tbFKod.Text, tbJelszo.Text, (Szerep)Enum.Parse(typeof(Szerep), cobSzerep.SelectedItem.ToString()), chbT.Checked, chbF.Checked);
                        felhasznalok.Add(a);
                        ujFelhasznalok.Add(a);
                    }
                    else
                    {
                        Felhasznalo h = new Felhasznalo(tbFNev.Text, tbFKod.Text, tbJelszo.Text, (Szerep)Enum.Parse(typeof(Szerep), cobSzerep.SelectedItem.ToString()));
                        felhasznalok.Add(h);
                        ujFelhasznalok.Add(h);
                    }
                }
                else
                {
                    MessageBox.Show("Már van ilyen kódú felhasználó !");
                }
            }
            else
            {
                MessageBox.Show("Hiányzó adatok");
            }
            tbFNev.Text = "";
            tbFKod.Text = "";
            tbJelszo.Text = "";
            cobSzerep.SelectedIndex = -1;
            chbT.Checked = false;
            chbF.Checked = false;
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            Mentes();
        }

        private void Mentes()
        {
            if (ujFelhasznalok.Count > 0)
            {
                StreamWriter w = new StreamWriter("Felhasznalok.txt", true);
                for (int i = 0; i < ujFelhasznalok.Count; i++)
                {
                    w.WriteLine(ujFelhasznalok[i].ToString());
                }
                w.Close();
            }
            if (ujTargyak.Count > 0)
            {
                StreamWriter w = new StreamWriter("Targyak.txt", true);
                for (int i = 0; i < ujTargyak.Count; i++)
                {
                    w.WriteLine(ujTargyak[i].ToString());
                }
                w.Close ();
            }
            ujFelhasznalok.Clear();
            ujTargyak.Clear();
            Close();
        }

        private void btnKilep_Click(object sender, EventArgs e)
        {
            ujFelhasznalok.Clear();
            ujTargyak.Clear();
            Close();
        }

        private void AdmForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ujFelhasznalok.Count > 0 || ujTargyak.Count > 0)
            {
                KilepForm ki = new KilepForm();
                if (ki.ShowDialog() == DialogResult.OK)
                {
                    Mentes();
                }
            }
        }
    } 
}
