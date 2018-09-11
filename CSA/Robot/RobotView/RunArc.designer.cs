namespace RobotView
{
    partial class RunArc
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.left_radio = new System.Windows.Forms.RadioButton();
            this.right_radio = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.angle_updown = new System.Windows.Forms.NumericUpDown();
            this.radius_updown = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.Text = "RunArc";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(2, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 26);
            this.label2.Text = "Radius (+ mm)";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(2, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 27);
            this.label3.Text = "Angle (+/- degree)";
            // 
            // left_radio
            // 
            this.left_radio.Location = new System.Drawing.Point(215, 5);
            this.left_radio.Name = "left_radio";
            this.left_radio.Size = new System.Drawing.Size(100, 20);
            this.left_radio.TabIndex = 3;
            this.left_radio.Text = "Left";
            // 
            // right_radio
            // 
            this.right_radio.Location = new System.Drawing.Point(321, 5);
            this.right_radio.Name = "right_radio";
            this.right_radio.Size = new System.Drawing.Size(100, 20);
            this.right_radio.TabIndex = 4;
            this.right_radio.Text = "Right";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "+/-";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // angle_updown
            // 
            this.angle_updown.Location = new System.Drawing.Point(215, 62);
            this.angle_updown.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.angle_updown.Name = "angle_updown";
            this.angle_updown.Size = new System.Drawing.Size(100, 28);
            this.angle_updown.TabIndex = 6;
            // 
            // radius_updown
            // 
            this.radius_updown.Location = new System.Drawing.Point(215, 31);
            this.radius_updown.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.radius_updown.Name = "radius_updown";
            this.radius_updown.Size = new System.Drawing.Size(100, 28);
            this.radius_updown.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "...";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(322, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 28);
            this.button3.TabIndex = 9;
            this.button3.Text = "...";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(368, 31);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(60, 58);
            this.Start.TabIndex = 10;
            this.Start.Text = "Start";
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // RunArc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.Start);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radius_updown);
            this.Controls.Add(this.angle_updown);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.right_radio);
            this.Controls.Add(this.left_radio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RunArc";
            this.Size = new System.Drawing.Size(455, 108);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton left_radio;
        private System.Windows.Forms.RadioButton right_radio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown angle_updown;
        private System.Windows.Forms.NumericUpDown radius_updown;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Start;
    }
}
