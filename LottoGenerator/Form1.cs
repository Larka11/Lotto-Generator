using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace LottoGenerator
{
    public partial class Form1 : Form
    {
        List<TextBox> lottoLines = new List<TextBox>(6);
        public int NoOfLinesSelected;
        public double LottoTotalCost = 2.50;

        public Form1()
        {
            InitializeComponent();
            lottoLines.Add(line1);
            lottoLines.Add(line2);
            lottoLines.Add(line3);
            lottoLines.Add(line4);
            lottoLines.Add(line5);
            lottoLines.Add(line6);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //initialize combobox
            LinesList.Items.Add("1");
            LinesList.Items.Add("2");
            LinesList.Items.Add("3");
            LinesList.Items.Add("4");
            LinesList.Items.Add("5");
            LinesList.Items.Add("6");
        }
        private void LinesList_SelectedIndexChanged(object sender, EventArgs e)

        {
            //store the selected number from the combobox in a variable
            NoOfLinesSelected = LinesList.SelectedIndex;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Fill the lotto pot
            var LottoNumbers = Enumerable.Range(1, 49).ToList();
            
            var PickedNumbers = new List<int>(6);

            var rng = new Random();

            // Draw 6 numbers
            for (int i = 0; i < 6; i++)
            {
                int randomBall = rng.Next(1, LottoNumbers.Count);
                PickedNumbers.Add(randomBall);

                // Don't pick the same number twice
                LottoNumbers.Remove(randomBall);
            }

            //print as many lines as customer wants
            for (int i = 0; NoOfLinesSelected >= 6; i++)
            {
                line1.Text = string.Join("  ", lottoLines[0]);
                line2.Text = string.Join("  ", lottoLines[1]);
                line3.Text = string.Join("  ", lottoLines[2]);
                line4.Text = string.Join("  ", lottoLines[3]);
                line5.Text = string.Join("  ", lottoLines[4]);
                line6.Text = string.Join("  ", lottoLines[5]);

            }
            //keep total
            TotalCostBox.Text = ("€" + Convert.ToString(LottoTotalCost));


        }




    }
}