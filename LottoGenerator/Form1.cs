using System;
using System.Collections.Generic;
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
                        int i;
            var numbers = new List<int>();
            var drawnNumbers = new List<int>();

            //It is important to only have have instance and re-use it. Creating a new one will result in LESS random numbers.
            var rng = new Random();

            //fill the list Numbers with a for loop here
            for (i = 1; i < 6; i++)
            {
                numbers[i] = rng.Next(1, 49); //Return random numbers seeded between 1 and 49
            }
            //draw 7 numbers from the Numbers and put them into DrawnNumbers

            for (i = 0; i < 6; i++)
            {
                int randomIndex = rng.Next(0, numbers.Count);
                int drawnInt;
                drawnInt = numbers[randomIndex];
                drawnNumbers.Add(drawnInt);
                numbers.Remove(drawnInt);
            }

            i = 1;

            for (i = 1; i < drawnNumbers.Count; i++)
            {
                lottoLineBox1.Text = drawnNumbers[i].ToString();
                lottoLineBox2.Text = drawnNumbers[i].ToString();
                lottoLineBox3.Text = drawnNumbers[i].ToString();
                lottoLineBox4.Text = drawnNumbers[i].ToString();
                lottoLineBox5.Text = drawnNumbers[i].ToString();
                lottoLineBox6.Text = drawnNumbers[i].ToString();
            }
        }
    }
}