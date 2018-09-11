using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestDrive
{
    public partial class Form1 : Form
    {
        private RobotCtrl.Drive drive;
        public Form1()
        {
            InitializeComponent();
            drive = new RobotCtrl.Drive();
            drive.Power = true;

            runTurnView.Drive = drive;
            runLine.Drive = drive;
            driveView.Drive = drive;

            // Events abfeuern, für die Default-Werte (Initialisierung)
            commonRunParameters_SpeedChanged(null, EventArgs.Empty);
            commonRunParameters_AccelerationChanged(null, EventArgs.Empty);


        }

        private void commonRunParameters_AccelerationChanged(object sender, EventArgs e)
        {
            runLine.Accleration = commonRunParameters.Acceleration;
            runTurnView.Acceleration = commonRunParameters.Acceleration;
            runArc.Accleration = commonRunParameters.Acceleration;
        }

        private void commonRunParameters_SpeedChanged(object sender, EventArgs e)
        {
            runLine.Speed = commonRunParameters.Speed;
            runTurnView.Speed = commonRunParameters.Speed;
            runArc.Speed = commonRunParameters.Speed;
        }
    }
}
