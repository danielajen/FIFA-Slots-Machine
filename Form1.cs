using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFA_Slots_Machine
{
    public partial class Form1 : Form
    {
        Random box = new Random();
        int number = 0;
        int number2 = 0;
        int number3 = 0;
        int score = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int number = box.Next(1, 10);
            // first one messi
            #region showpics
            if (number == 1) pb1messi.Image = Properties.Resources._0_top_22_neuer_manuel;
            if (number == 2) pb1messi.Image = Properties.Resources.alphonso_davies_png_adapt_crop16x9_652w;
            if (number == 3) pb1messi.Image = Properties.Resources.heung_min_son_png_adapt_crop16x9_652w;
            if (number == 4) pb1messi.Image = Properties.Resources.van_Dijk__1_;
            if (number == 5) pb1messi.Image = Properties.Resources.jadon_sancho_png_adapt_crop16x9_652w;
            if (number == 6) pb1messi.Image = Properties.Resources.GabrielJesus;
            if (number == 7) pb1messi.Image = Properties.Resources.Manzala;
            if (number == 8) pb1messi.Image = Properties.Resources.r908859_612x918_2_3;
            if (number == 9) pb1messi.Image = Properties.Resources.varane;
            if (number == 10) pb1messi.Image = Properties.Resources.fifa_22_collins_winter_wildcards;
            #endregion
            int number2 = box.Next(1, 10);
            // second one lewa
            #region showpics
            if (number2 == 1) pblewa2.Image = Properties.Resources._0_top_22_neuer_manuel;
            if (number2 == 2) pblewa2.Image = Properties.Resources.alphonso_davies_png_adapt_crop16x9_652w;
            if (number2 == 3) pblewa2.Image = Properties.Resources.heung_min_son_png_adapt_crop16x9_652w;
            if (number2 == 4) pblewa2.Image = Properties.Resources.van_Dijk__1_;
            if (number2 == 5) pblewa2.Image = Properties.Resources.jadon_sancho_png_adapt_crop16x9_652w;
            if (number2 == 6) pblewa2.Image = Properties.Resources.GabrielJesus;
            if (number2 == 7) pblewa2.Image = Properties.Resources.Manzala;
            if (number2 == 8) pblewa2.Image = Properties.Resources.r908859_612x918_2_3;
            if (number2 == 9) pblewa2.Image = Properties.Resources.varane;
            if (number2 == 10) pblewa2.Image = Properties.Resources.fifa_22_collins_winter_wildcards;
            #endregion

            int number3 = box.Next(1, 10);
            // third one suii
            #region showpics
            if (number3 == 1) pbronaldo.Image = Properties.Resources._0_top_22_neuer_manuel;
            if (number3 == 2) pbronaldo.Image = Properties.Resources.alphonso_davies_png_adapt_crop16x9_652w;
            if (number3 == 3) pbronaldo.Image = Properties.Resources.heung_min_son_png_adapt_crop16x9_652w;
            if (number3 == 4) pbronaldo.Image = Properties.Resources.van_Dijk__1_;
            if (number3 == 5) pbronaldo.Image = Properties.Resources.jadon_sancho_png_adapt_crop16x9_652w;
            if (number3 == 6) pbronaldo.Image = Properties.Resources.GabrielJesus;
            if (number3 == 7) pbronaldo.Image = Properties.Resources.Manzala;
            if (number3 == 8) pbronaldo.Image = Properties.Resources.r908859_612x918_2_3;
            if (number3 == 9) pbronaldo.Image = Properties.Resources.varane;
            if (number3 == 10) pbronaldo.Image = Properties.Resources.fifa_22_collins_winter_wildcards;
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            score = score - 10;
            label2.Text = score.ToString();

            if (button1.Text == "Open Pack")
            {
                timer1.Start();
                button1.Text = "STOP";
                score = score + 10;
            }
            else
            {
                timer1.Stop();
                button1.Text = "Open Pack";
                //checking code

                if (number == 1 && number2 == 1 && number3 == 1)
                {
                    score = score + 500;
                    MessageBox.Show("you got three in a row");
                }
               else if (number == 2 && number2 == 2 && number3 == 2)
                {
                    score = score + 500;
                    MessageBox.Show("you got three in a row");
                }
               else  if (number == 3 && number2 == 3 && number3 == 3)
                {
                    score = score + 500;
                    MessageBox.Show("you got three in a row");
                }
               else if (number == 4 && number2 == 4 && number3 == 4)
                {
                    score = score + 500;
                    MessageBox.Show("you got three in a row");
                }
              else  if (number == 5 && number2 == 5 && number3 == 5)
                {
                    score = score + 500;
                    MessageBox.Show("you got three in a row");
                }
                else if (number == 6 && number2 == 6 && number3 == 6)
                {
                    score = score + 500;
                    MessageBox.Show("you got three in a row");
                }
               else if (number == 7 && number2 == 7 && number3 == 7)
                {
                    score = score + 500;
                    MessageBox.Show("you got three in a row");
                }
               else if (number == 8 && number2 == 8 && number3 == 8)
                {
                    score = score + 500;
                    MessageBox.Show("you got three in a row");
                }
               else if (number == 9 && number2 == 9 && number3 == 9)
                {
                    score = score + 500;
                    MessageBox.Show("you got three in a row");
                }
              else  if (number == 10 && number2 == 10 && number3 == 10)
                {
                    score = score + 500;
                    MessageBox.Show("you got three in a row");
                }
            }
        }

        private void pblewa2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void pbronaldo_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
