namespace Testat_FS18
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Copyright = new System.Windows.Forms.Label();
            this.commonRunParameters = new RobotView.CommonRunParameters();
            this.driveView = new RobotView.DriveView();
            this.runArcView = new RobotView.RunArc();
            this.runLineView = new RobotView.RunLine();
            this.runTurnView = new RobotView.RunTurnView();
            this.radarView = new RobotView.RadarView();
            this.consoleView = new RobotView.ConsoleView();
            this.label_anzeige = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonHalt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_ParkingState = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer();
            this.SuspendLayout();
            // 
            // label_Copyright
            // 
            this.label_Copyright.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_Copyright.Location = new System.Drawing.Point(0, 474);
            this.label_Copyright.Name = "label_Copyright";
            this.label_Copyright.Size = new System.Drawing.Size(855, 25);
            this.label_Copyright.Text = "Copyright by Patrick Loosli und Burak Kizilkaya";
            this.label_Copyright.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // commonRunParameters
            // 
            this.commonRunParameters.Acceleration = 0.3F;
            this.commonRunParameters.Location = new System.Drawing.Point(377, 0);
            this.commonRunParameters.Name = "commonRunParameters";
            this.commonRunParameters.Size = new System.Drawing.Size(474, 105);
            this.commonRunParameters.Speed = 0.5F;
            this.commonRunParameters.TabIndex = 5;
            // 
            // driveView
            // 
            this.driveView.Drive = null;
            this.driveView.Location = new System.Drawing.Point(4, 4);
            this.driveView.Name = "driveView";
            this.driveView.Size = new System.Drawing.Size(365, 361);
            this.driveView.TabIndex = 1;
            // 
            // runArcView
            // 
            this.runArcView.Accleration = 0F;
            this.runArcView.Drive = null;
            this.runArcView.Location = new System.Drawing.Point(377, 149);
            this.runArcView.Name = "runArcView";
            this.runArcView.Size = new System.Drawing.Size(455, 108);
            this.runArcView.Speed = 0F;
            this.runArcView.TabIndex = 4;
            // 
            // runLineView
            // 
            this.runLineView.Accleration = 0F;
            this.runLineView.Drive = null;
            this.runLineView.Location = new System.Drawing.Point(377, 93);
            this.runLineView.Name = "runLineView";
            this.runLineView.Size = new System.Drawing.Size(455, 50);
            this.runLineView.Speed = 0F;
            this.runLineView.TabIndex = 3;
            // 
            // runTurnView
            // 
            this.runTurnView.Acceleration = 0F;
            this.runTurnView.Drive = null;
            this.runTurnView.Location = new System.Drawing.Point(377, 249);
            this.runTurnView.Name = "runTurnView";
            this.runTurnView.Size = new System.Drawing.Size(474, 55);
            this.runTurnView.Speed = 0F;
            this.runTurnView.TabIndex = 2;
            // 
            // radarView
            // 
            this.radarView.Location = new System.Drawing.Point(377, 344);
            this.radarView.Name = "radarView";
            this.radarView.Radar = null;
            this.radarView.Size = new System.Drawing.Size(155, 52);
            this.radarView.TabIndex = 7;
            // 
            // consoleView
            // 
            this.consoleView.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.consoleView.Console = null;
            this.consoleView.Location = new System.Drawing.Point(558, 344);
            this.consoleView.Name = "consoleView";
            this.consoleView.Size = new System.Drawing.Size(208, 46);
            this.consoleView.TabIndex = 8;
            // 
            // label_anzeige
            // 
            this.label_anzeige.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label_anzeige.Location = new System.Drawing.Point(377, 308);
            this.label_anzeige.Name = "label_anzeige";
            this.label_anzeige.Size = new System.Drawing.Size(162, 32);
            this.label_anzeige.Text = "Anzeige";
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(25, 372);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(130, 88);
            this.buttonStop.TabIndex = 9;
            this.buttonStop.Text = "Stop";
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonHalt
            // 
            this.buttonHalt.Location = new System.Drawing.Point(213, 372);
            this.buttonHalt.Name = "buttonHalt";
            this.buttonHalt.Size = new System.Drawing.Size(130, 88);
            this.buttonHalt.TabIndex = 10;
            this.buttonHalt.Text = "Halt";
            this.buttonHalt.Click += new System.EventHandler(this.buttonHalt_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(377, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 26);
            this.label1.Text = "Parkmanöver Status:";
            // 
            // label_ParkingState
            // 
            this.label_ParkingState.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_ParkingState.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.label_ParkingState.Location = new System.Drawing.Point(582, 421);
            this.label_ParkingState.Name = "label_ParkingState";
            this.label_ParkingState.Size = new System.Drawing.Size(250, 26);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(855, 499);
            this.Controls.Add(this.label_ParkingState);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonHalt);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.label_anzeige);
            this.Controls.Add(this.label_Copyright);
            this.Controls.Add(this.driveView);
            this.Controls.Add(this.runTurnView);
            this.Controls.Add(this.runLineView);
            this.Controls.Add(this.runArcView);
            this.Controls.Add(this.commonRunParameters);
            this.Controls.Add(this.radarView);
            this.Controls.Add(this.consoleView);
            this.Name = "Form1";
            this.Text = "Testat FS18";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Copyright;
        private RobotView.DriveView driveView;
        private RobotView.RunArc runArcView;
        private RobotView.RunLine runLineView;
        private RobotView.RunTurnView runTurnView;
        private RobotView.CommonRunParameters commonRunParameters;
        private RobotView.RadarView radarView;
        private RobotView.ConsoleView consoleView;
        private System.Windows.Forms.Label label_anzeige;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonHalt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_ParkingState;
        private System.Windows.Forms.Timer timer1;
    }
}

