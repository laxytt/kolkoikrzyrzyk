using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kółko_i_krzyżyk
{
    public partial class kolkoikrzyzyk : Form
    {
        bool gracz = true; // true = Gracz X ; false = Gracz Y
        int iloscRuchow = 0;



        public kolkoikrzyzyk()
        {
            InitializeComponent();
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Wiktor", "About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Button b = (Button)sender;
            if (gracz)
            {

                b.Text = "X";
                ruchgracza.Text = "Ruch gracza Y";
            }
            else
            {

                b.Text = "O";
                ruchgracza.Text = "Ruch gracza X";
            }
            gracz = !gracz;
            b.Enabled = false;
            iloscRuchow++;
            



        }




        private void timer1_Tick(object sender, EventArgs e)
        {

           
            
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text))
            {
                ruchgracza.Text = "Koniec gry";
                timer1.Enabled=false;
            }
            else if (B1.Text == B2.Text && B2.Text == B3.Text && A1.Enabled)
            {
                ruchgracza.Text = "Koniec gry";
                timer1.Stop();
            }
            else if (C1.Text == C2.Text && C2.Text == C3.Text && A1.Enabled)
            {
                ruchgracza.Text = "Koniec gry";
                timer1.Stop();
            }
           

            

            if (A1.Text == B1.Text && B1.Text == C1.Text)
            {
                ruchgracza.Text = "Koniec gry";
                timer1.Stop();
            }
            if (A2.Text == B2.Text && B2.Text == C2.Text)
            {
                ruchgracza.Text = "Koniec gry";
                timer1.Stop();
            }
            if (A3.Text == B3.Text && B3.Text == C3.Text)
            {
                ruchgracza.Text = "Koniec gry";
                timer1.Stop();
            }
            // sprawdza po skosie czy ktos wygrał
            if (A1.Text == B2.Text && B2.Text == C3.Text)
            {
                ruchgracza.Text = "Koniec gry";
                timer1.Stop();
            }
            if (A3.Text == B2.Text && B2.Text == C1.Text)
            {
                ruchgracza.Text = "Koniec gry";
                timer1.Stop();
            }

            

            
        }
    }
}
