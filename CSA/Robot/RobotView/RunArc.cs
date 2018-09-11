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
    public partial class RunArc : UserControl
    {
        private float speed;
        private float acceleration;

        public Drive Drive { get; set; }
        public RunArc()
        {
            InitializeComponent();
        }
        #region properties
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
        #endregion

        //Start Button gedrück 
        private void Start_Click(object sender, EventArgs e)
        {
            if (left_radio.Checked)
            {
                this.Drive.RunArcLeft((float)this.radius_updown.Value / 1000, (float)this.angle_updown.Value, this.speed, this.acceleration);
            }
            else
            {
                this.Drive.RunArcRight((float)this.radius_updown.Value / 1000, (float)this.angle_updown.Value, this.speed, this.acceleration);
            }
            
            
        }

        //Distanz eingeben (radius_updown.Value)
        private void button2_Click(object sender, EventArgs e)
        {
            NumberKeyboard numberkeyboard = new NumberKeyboard();
            numberkeyboard.Number = (float)radius_updown.Value;
            if (numberkeyboard.ShowDialog() == DialogResult.OK)
            {
                radius_updown.Value = (decimal)numberkeyboard.Number;
            }
        }
        // Winkel eingeben (angle_updown.Value)
        private void button3_Click(object sender, EventArgs e)
        {
            NumberKeyboard numberkeyboard = new NumberKeyboard();
            numberkeyboard.Number = (float)angle_updown.Value;
            if (numberkeyboard.ShowDialog() == DialogResult.OK)
            {
                angle_updown.Value = (decimal)numberkeyboard.Number;
            }
        }
        //Vorzeichen wechsel von Winkel (angle_updown.Value)
        private void button1_Click(object sender, EventArgs e)
        {
            angle_updown.Value *= (-1);
        }
    }
}