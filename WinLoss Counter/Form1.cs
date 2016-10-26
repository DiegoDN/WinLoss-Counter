/*
MIT License

Copyright (c) 2016, Diego de Niro

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE. 
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinLoss_Counter
{
    public partial class Form1 : Form
    {
        int wonValue = 0;
        int lostValue = 0;
        int totalFightsValue = 0;
        float winRatioFloat;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            new ToolTip().SetToolTip(punchPictureBox, "Click for About Text");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            wonValue += 1;
            wonTextBox.Text = wonValue.ToString();
            totalFightsUpdate(0);
        }

        private void buttonLostPlus_Click(object sender, EventArgs e)
        {
            lostValue += 1;
            lostTextBox.Text = lostValue.ToString();
            totalFightsUpdate(0);
        }

        private void buttonWonMinus_Click(object sender, EventArgs e)
        {
            
            if (wonValue > 0)
            {
                wonValue -= 1;
                wonTextBox.Text = wonValue.ToString();
                totalFightsUpdate(1);
            }
            else
            {
                wonTextBox.Text = "0";
                wonValue = 0;
            }
        }

        private void buttonLostMinus_Click(object sender, EventArgs e)
        {
            if (lostValue > 0)
            {
                lostValue -= 1;
                lostTextBox.Text = lostValue.ToString();
                totalFightsUpdate(1);
            }
            else
            {
                lostTextBox.Text = "0";
                lostValue = 0;
            }
        }


        private void wonTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void testTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void totalFightsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalFightsUpdate(int PlusorMinus){
            if (PlusorMinus == 0)
            {
                totalFightsValue += 1;
                totalFightsTextBox.Text = totalFightsValue.ToString();
                winRatioFloat = float.Parse(wonTextBox.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat) / float.Parse(totalFightsTextBox.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
                winRatio.Text = ((winRatioFloat).ToString("0.00 %"));
            }
            if (PlusorMinus == 1)
            {
                totalFightsValue -= 1;
                
                if (totalFightsValue > 0)
                {
                    totalFightsTextBox.Text = totalFightsValue.ToString();
                    winRatioFloat = float.Parse(wonTextBox.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat) / float.Parse(totalFightsTextBox.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
                    winRatio.Text = ((winRatioFloat).ToString("0.00 %"));

                }
                else
                {
                    totalFightsTextBox.Text = "0";
                    totalFightsValue = 0;
                    winRatio.Text = "Go Fight!";
                }
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}
