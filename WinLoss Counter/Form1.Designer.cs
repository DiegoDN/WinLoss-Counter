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

namespace WinLoss_Counter
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.wonTextBox = new System.Windows.Forms.TextBox();
            this.wonLabel = new System.Windows.Forms.Label();
            this.lostLabel = new System.Windows.Forms.Label();
            this.lostTextBox = new System.Windows.Forms.TextBox();
            this.buttonWonPlus = new System.Windows.Forms.Button();
            this.buttonWonMinus = new System.Windows.Forms.Button();
            this.buttonLostMinus = new System.Windows.Forms.Button();
            this.buttonLostPlus = new System.Windows.Forms.Button();
            this.totalFightsTextBox = new System.Windows.Forms.TextBox();
            this.currentWins = new System.Windows.Forms.Label();
            this.winRatio = new System.Windows.Forms.Label();
            this.totalFightsLabel = new System.Windows.Forms.Label();
            this.punchPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.punchPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // wonTextBox
            // 
            this.wonTextBox.Location = new System.Drawing.Point(84, 15);
            this.wonTextBox.Name = "wonTextBox";
            this.wonTextBox.ReadOnly = true;
            this.wonTextBox.Size = new System.Drawing.Size(45, 20);
            this.wonTextBox.TabIndex = 20;
            this.wonTextBox.TabStop = false;
            this.wonTextBox.Text = "0";
            this.wonTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wonTextBox.TextChanged += new System.EventHandler(this.wonTextBox_TextChanged);
            // 
            // wonLabel
            // 
            this.wonLabel.AutoSize = true;
            this.wonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wonLabel.Location = new System.Drawing.Point(22, 15);
            this.wonLabel.Name = "wonLabel";
            this.wonLabel.Size = new System.Drawing.Size(42, 20);
            this.wonLabel.TabIndex = 2;
            this.wonLabel.Text = "Won";
            this.wonLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // lostLabel
            // 
            this.lostLabel.AutoSize = true;
            this.lostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lostLabel.Location = new System.Drawing.Point(22, 53);
            this.lostLabel.Name = "lostLabel";
            this.lostLabel.Size = new System.Drawing.Size(40, 20);
            this.lostLabel.TabIndex = 4;
            this.lostLabel.Text = "Lost";
            this.lostLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // lostTextBox
            // 
            this.lostTextBox.Location = new System.Drawing.Point(84, 53);
            this.lostTextBox.Name = "lostTextBox";
            this.lostTextBox.ReadOnly = true;
            this.lostTextBox.Size = new System.Drawing.Size(45, 20);
            this.lostTextBox.TabIndex = 30;
            this.lostTextBox.TabStop = false;
            this.lostTextBox.Text = "0";
            this.lostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lostTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonWonPlus
            // 
            this.buttonWonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWonPlus.Location = new System.Drawing.Point(135, 14);
            this.buttonWonPlus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWonPlus.Name = "buttonWonPlus";
            this.buttonWonPlus.Size = new System.Drawing.Size(20, 20);
            this.buttonWonPlus.TabIndex = 5;
            this.buttonWonPlus.Text = "+";
            this.buttonWonPlus.UseVisualStyleBackColor = true;
            this.buttonWonPlus.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonWonMinus
            // 
            this.buttonWonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWonMinus.Location = new System.Drawing.Point(163, 14);
            this.buttonWonMinus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWonMinus.Name = "buttonWonMinus";
            this.buttonWonMinus.Size = new System.Drawing.Size(20, 20);
            this.buttonWonMinus.TabIndex = 6;
            this.buttonWonMinus.Text = "-";
            this.buttonWonMinus.UseVisualStyleBackColor = true;
            this.buttonWonMinus.Click += new System.EventHandler(this.buttonWonMinus_Click);
            // 
            // buttonLostMinus
            // 
            this.buttonLostMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonLostMinus.Location = new System.Drawing.Point(163, 52);
            this.buttonLostMinus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLostMinus.Name = "buttonLostMinus";
            this.buttonLostMinus.Size = new System.Drawing.Size(20, 20);
            this.buttonLostMinus.TabIndex = 8;
            this.buttonLostMinus.Text = "-";
            this.buttonLostMinus.UseVisualStyleBackColor = true;
            this.buttonLostMinus.Click += new System.EventHandler(this.buttonLostMinus_Click);
            // 
            // buttonLostPlus
            // 
            this.buttonLostPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonLostPlus.Location = new System.Drawing.Point(135, 52);
            this.buttonLostPlus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLostPlus.Name = "buttonLostPlus";
            this.buttonLostPlus.Size = new System.Drawing.Size(20, 20);
            this.buttonLostPlus.TabIndex = 7;
            this.buttonLostPlus.Text = "+";
            this.buttonLostPlus.UseVisualStyleBackColor = true;
            this.buttonLostPlus.Click += new System.EventHandler(this.buttonLostPlus_Click);
            // 
            // totalFightsTextBox
            // 
            this.totalFightsTextBox.Location = new System.Drawing.Point(84, 93);
            this.totalFightsTextBox.Name = "totalFightsTextBox";
            this.totalFightsTextBox.ReadOnly = true;
            this.totalFightsTextBox.Size = new System.Drawing.Size(45, 20);
            this.totalFightsTextBox.TabIndex = 9;
            this.totalFightsTextBox.TabStop = false;
            this.totalFightsTextBox.Text = "0";
            this.totalFightsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalFightsTextBox.TextChanged += new System.EventHandler(this.totalFightsTextBox_TextChanged);
            // 
            // currentWins
            // 
            this.currentWins.AutoSize = true;
            this.currentWins.Location = new System.Drawing.Point(18, 136);
            this.currentWins.Name = "currentWins";
            this.currentWins.Size = new System.Drawing.Size(111, 13);
            this.currentWins.TabIndex = 11;
            this.currentWins.Text = "Your current Win % is:";
            this.currentWins.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // winRatio
            // 
            this.winRatio.AutoSize = true;
            this.winRatio.Location = new System.Drawing.Point(130, 136);
            this.winRatio.Name = "winRatio";
            this.winRatio.Size = new System.Drawing.Size(50, 13);
            this.winRatio.TabIndex = 31;
            this.winRatio.Text = "Go Fight!";
            // 
            // totalFightsLabel
            // 
            this.totalFightsLabel.AutoSize = true;
            this.totalFightsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFightsLabel.Location = new System.Drawing.Point(22, 93);
            this.totalFightsLabel.Name = "totalFightsLabel";
            this.totalFightsLabel.Size = new System.Drawing.Size(53, 20);
            this.totalFightsLabel.TabIndex = 32;
            this.totalFightsLabel.Text = "Fights";
            this.totalFightsLabel.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // punchPictureBox
            // 
            this.punchPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.punchPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("punchPictureBox.Image")));
            this.punchPictureBox.Location = new System.Drawing.Point(188, 28);
            this.punchPictureBox.Name = "punchPictureBox";
            this.punchPictureBox.Size = new System.Drawing.Size(73, 74);
            this.punchPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.punchPictureBox.TabIndex = 33;
            this.punchPictureBox.TabStop = false;
            this.punchPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 162);
            this.Controls.Add(this.totalFightsLabel);
            this.Controls.Add(this.winRatio);
            this.Controls.Add(this.currentWins);
            this.Controls.Add(this.totalFightsTextBox);
            this.Controls.Add(this.buttonLostMinus);
            this.Controls.Add(this.buttonLostPlus);
            this.Controls.Add(this.buttonWonMinus);
            this.Controls.Add(this.buttonWonPlus);
            this.Controls.Add(this.lostLabel);
            this.Controls.Add(this.lostTextBox);
            this.Controls.Add(this.wonLabel);
            this.Controls.Add(this.wonTextBox);
            this.Controls.Add(this.punchPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Win/Loss Counter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.punchPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wonTextBox;
        private System.Windows.Forms.Label wonLabel;
        private System.Windows.Forms.Label lostLabel;
        private System.Windows.Forms.TextBox lostTextBox;
        private System.Windows.Forms.Button buttonWonPlus;
        private System.Windows.Forms.Button buttonWonMinus;
        private System.Windows.Forms.Button buttonLostMinus;
        private System.Windows.Forms.Button buttonLostPlus;
        private System.Windows.Forms.TextBox totalFightsTextBox;
        private System.Windows.Forms.Label currentWins;
        private System.Windows.Forms.Label winRatio;
        private System.Windows.Forms.Label totalFightsLabel;
        private System.Windows.Forms.PictureBox punchPictureBox;
    }
} 