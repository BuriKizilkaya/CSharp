namespace TestMotor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.driveCtrView = new RobotView.DriveCtrlView();
            this.motorCtrlViewRight = new RobotView.MotorCtrlView();
            this.motorCtrViewLeft = new RobotView.MotorCtrlView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // driveCtrView
            // 
            this.driveCtrView.BackColor = System.Drawing.Color.Red;
            this.driveCtrView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driveCtrView.DriveCtrl = null;
            this.driveCtrView.Location = new System.Drawing.Point(0, 0);
            this.driveCtrView.Name = "driveCtrView";
            this.driveCtrView.Size = new System.Drawing.Size(542, 320);
            this.driveCtrView.TabIndex = 1;
            // 
            // motorCtrlViewRight
            // 
            this.motorCtrlViewRight.BackColor = System.Drawing.Color.Red;
            this.motorCtrlViewRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.motorCtrlViewRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.motorCtrlViewRight.Location = new System.Drawing.Point(0, 0);
            this.motorCtrlViewRight.MotorCtrl = null;
            this.motorCtrlViewRight.Name = "motorCtrlViewRight";
            this.motorCtrlViewRight.Size = new System.Drawing.Size(542, 320);
            this.motorCtrlViewRight.TabIndex = 3;
            // 
            // motorCtrViewLeft
            // 
            this.motorCtrViewLeft.BackColor = System.Drawing.Color.Red;
            this.motorCtrViewLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.motorCtrViewLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.motorCtrViewLeft.Location = new System.Drawing.Point(0, 0);
            this.motorCtrViewLeft.MotorCtrl = null;
            this.motorCtrViewLeft.Name = "motorCtrViewLeft";
            this.motorCtrViewLeft.Size = new System.Drawing.Size(542, 320);
            this.motorCtrViewLeft.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(550, 354);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.driveCtrView);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(542, 320);
            this.tabPage3.Text = "Drive Ctrl";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.motorCtrViewLeft);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(542, 320);
            this.tabPage1.Text = "Motor Ctrl Left";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.motorCtrlViewRight);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(542, 320);
            this.tabPage2.Text = "Motor Ctrl Right";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(559, 432);
            this.Controls.Add(this.tabControl1);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Robo Motor Ctrl";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private RobotView.DriveCtrlView driveCtrView;
        private RobotView.MotorCtrlView motorCtrViewLeft;
        private RobotView.MotorCtrlView motorCtrlViewRight;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

