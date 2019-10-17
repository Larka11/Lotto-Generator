using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LottoGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

            line1.Text = string.Join("  ", PickedNumbers);
        }
    }
}