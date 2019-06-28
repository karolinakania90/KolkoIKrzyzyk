using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KolkoIKrzyzyk
{
    public partial class GraKolkoIKrzyzyk : Form
    {

        private Gra gra;

        public GraKolkoIKrzyzyk()
        {
            InitializeComponent();
            gra = new Gra();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var test = new Gra();
            test.LosujRuch("O");
        }

        private void GraKolkoIKrzyzyk_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "X";
            button5.Enabled = false;
            gra.KolejnyRuch(0, 0, "X");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
