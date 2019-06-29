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

            ZmienStanMacierzy(false);
        }

        private void ZmienStanMacierzy(bool stan)
        {
            button1.Enabled = stan;
            button2.Enabled = stan;
            button3.Enabled = stan;
            button4.Enabled = stan;
            button5.Enabled = stan;
            button6.Enabled = stan;
            button7.Enabled = stan;
            button8.Enabled = stan;
            button9.Enabled = stan;
        }

        private void GraKolkoIKrzyzyk_Load(object sender, EventArgs e)
        {
        }


        private void StartButton_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "Trwa rozgrywka!";

            startButton.Enabled = false;
            ZmienStanMacierzy(true);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.Text = gra.KolejnyRuch(0, 0);

            RuchKomputera();
            WylonZwyciesce();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button2.Text = gra.KolejnyRuch(0, 1);

            RuchKomputera();
            WylonZwyciesce();
        }

        private void RuchKomputera()
        {
            if (gra.KoniecGry == false)
            {
                Ruch wylosowanyRuch = gra.LosujRuch();
                if (wylosowanyRuch.Pole.X == 0 && wylosowanyRuch.Pole.Y == 0)
                {
                    button1.Text = wylosowanyRuch.Symbol;
                    button1.Enabled = false;
                }

                if (wylosowanyRuch.Pole.X == 0 && wylosowanyRuch.Pole.Y == 1)
                {
                    button2.Text = wylosowanyRuch.Symbol;
                    button2.Enabled = false;
                }

                if (wylosowanyRuch.Pole.X == 0 && wylosowanyRuch.Pole.Y == 2)
                {
                    button3.Text = wylosowanyRuch.Symbol;
                    button3.Enabled = false;
                }

                if (wylosowanyRuch.Pole.X == 1 && wylosowanyRuch.Pole.Y == 0)
                {
                    button4.Text = wylosowanyRuch.Symbol;
                    button4.Enabled = false;
                }

                if (wylosowanyRuch.Pole.X == 1 && wylosowanyRuch.Pole.Y == 1)
                {
                    button5.Text = wylosowanyRuch.Symbol;
                    button5.Enabled = false;
                }

                if (wylosowanyRuch.Pole.X == 1 && wylosowanyRuch.Pole.Y == 2)
                {
                    button6.Text = wylosowanyRuch.Symbol;
                    button6.Enabled = false;
                }

                if (wylosowanyRuch.Pole.X == 2 && wylosowanyRuch.Pole.Y == 0)
                {
                    button7.Text = wylosowanyRuch.Symbol;
                    button7.Enabled = false;
                }

                if (wylosowanyRuch.Pole.X == 2 && wylosowanyRuch.Pole.Y == 1)
                {
                    button8.Text = wylosowanyRuch.Symbol;
                    button8.Enabled = false;
                }

                if (wylosowanyRuch.Pole.X == 2 && wylosowanyRuch.Pole.Y == 2)
                {
                    button9.Text = wylosowanyRuch.Symbol;
                    button9.Enabled = false;
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button3.Text = gra.KolejnyRuch(0, 2);
            RuchKomputera();
            WylonZwyciesce();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button4.Text = gra.KolejnyRuch(1, 0);
            RuchKomputera();
            WylonZwyciesce();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button5.Text = gra.KolejnyRuch(1, 1);
            RuchKomputera();
            WylonZwyciesce();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            button6.Text = gra.KolejnyRuch(1, 2);
            RuchKomputera();
            WylonZwyciesce();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            button7.Text = gra.KolejnyRuch(2, 0);
            RuchKomputera();
            WylonZwyciesce();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            button8.Text = gra.KolejnyRuch(2, 1);
            RuchKomputera();
            WylonZwyciesce();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            button9.Text = gra.KolejnyRuch(2, 2);
            RuchKomputera();
            WylonZwyciesce();
        }

        private void WylonZwyciesce()
        {
            var wygrany = gra.SprawdzKtoWygral();
            if (wygrany != null)
            {
                statusLabel.Text = wygrany.Symbol;

                if (wygrany.Poczatkowe.X == 0 && wygrany.Poczatkowe.Y == 0
                    && wygrany.Koncowe.X == 0 && wygrany.Koncowe.Y == 2)
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Red;
                    ZmienStanMacierzy(false);
                }
                
            }
        }
    }
}
