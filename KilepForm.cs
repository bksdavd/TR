using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TanulmanyiRendszerUjra
{
    public partial class KilepForm : Form
    {
        public KilepForm()
        {
            InitializeComponent();
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnKilep_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
