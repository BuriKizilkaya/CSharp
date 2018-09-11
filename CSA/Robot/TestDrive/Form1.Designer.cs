namespace TestDrive
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
            this.commonRunParameters = new RobotView.CommonRunParameters();
            this.driveView = new RobotView.DriveView();
            this.runLine = new RobotView.RunLine();
            this.runTurnView = new RobotView.RunTurnView();
            this.runArc = new RobotView.RunArc();
            this.SuspendLayout();
            // 
            // commonRunParameters
            // 
            this.commonRunParameters.Acceleration = 0.3F;
            this.commonRunParameters.Location = new System.Drawing.Point(449, 4);
            this.commonRunParameters.Name = "commonRunParameters";
            this.commonRunParameters.Size = new System.Drawing.Size(512, 105);
            this.commonRunParameters.Speed = 0.5F;
            this.commonRunParameters.TabIndex = 1;
            this.commonRunParameters.SpeedChanged += new System.EventHandler(this.commonRunParameters_SpeedChanged);
            this.commonRunParameters.AccelerationChanged += new System.EventHandler(this.commonRunParameters_AccelerationChanged);
            // 
            // driveView
            // 
            this.driveView.Drive = null;
            this.driveView.Location = new System.Drawing.Point(3, 4);
            this.driveView.Name = "driveView";
            this.driveView.Size = new System.Drawing.Size(438, 361);
            this.driveView.TabIndex = 2;
            // 
            // runLine
            // 
            this.runLine.Accleration = 0F;
            this.runLine.Drive = null;
            this.runLine.Location = new System.Drawing.Point(449, 116);
            this.runLine.Name = "runLine";
            this.runLine.Size = new System.Drawing.Size(472, 60);
            this.runLine.Speed = 0F;
            this.runLine.TabIndex = 3;
            // 
            // runTurnView
            // 
            this.runTurnView.Acceleration = 0F;
            this.runTurnView.Drive = null;
            this.runTurnView.Location = new System.Drawing.Point(449, 182);
            this.runTurnView.Name = "runTurnView";
            this.runTurnView.Size = new System.Drawing.Size(489, 67);
            this.runTurnView.Speed = 0F;
            this.runTurnView.TabIndex = 4;
            // 
            // runArc
            // 
            this.runArc.Accleration = 0F;
            this.runArc.Drive = null;
            this.runArc.Location = new System.Drawing.Point(449, 257);
            this.runArc.Name = "runArc";
            this.runArc.Size = new System.Drawing.Size(455, 108);
            this.runArc.Speed = 0F;
            this.runArc.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(965, 548);
            this.Controls.Add(this.commonRunParameters);
            this.Controls.Add(this.driveView);
            this.Controls.Add(this.runLine);
            this.Controls.Add(this.runTurnView);
            this.Controls.Add(this.runArc);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private RobotView.CommonRunParameters commonRunParameters;
        private RobotView.DriveView driveView;
        private RobotView.RunTurnView runTurnView;
        private RobotView.RunLine runLine;
        private RobotView.RunArc runArc;
    }
}

