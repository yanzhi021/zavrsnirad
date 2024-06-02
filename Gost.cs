using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zavrsnirad
{
    public partial class Gost : Form
    {
        public Gost()
        {
            InitializeComponent();
        }

        private void btnZaOvdje_Click(object sender, EventArgs e)
        {
            Form NarudžbaZaOvdje = new NarudžbaZaOvdje();
            NarudžbaZaOvdje.Show();
        }
    }
}
