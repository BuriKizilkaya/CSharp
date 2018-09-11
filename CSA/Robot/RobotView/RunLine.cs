using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using RobotCtrl;

namespace RobotView
{
    public partial class RunLine : UserControl
    {

        private float speed;
        private float acceleration;
        public Drive Drive { get; set; }
        public RunLine()
        {
            InitializeComponent();
        }
        public float Accleration
        {
            get { return acceleration; }
            set { acceleration = value; }
        }
        public float Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        private void label1_ParentChanged(object sender, EventArgs e)
        {

        }

        private void label2_ParentChanged(object sender, EventArgs e)
        {

        }

        // ... Button
        private void button2_Click(object sender, EventArgs e)
        {
            NumberKeyboard numberkeyboard = new NumberKeyboard();
            numberkeyboard.Number = (float)numericUpDown1.Value;
            if(numberkeyboard.ShowDialog() == DialogResult.OK)
            {
                numericUpDown1.Value = (decimal)numberkeyboard.Number;
            }

        }
        // +/- Button
        private void button1_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value *= (-1);
        }

        private void numericUpDown1_KeyUp(object sender, KeyEventArgs e)
        {
            numericUpDown1.Value++;
        }

        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            numericUpDown1.Value--;
        }

        // Start button
        private void button3_Click(object sender, EventArgs e)
        {
            this.Drive.RunLine((float)this.numericUpDown1.Value / 1000, this.speed, this.acceleration);
        }
    }
}