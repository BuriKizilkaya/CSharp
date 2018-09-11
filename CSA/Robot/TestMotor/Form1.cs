using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RobotCtrl; 

namespace TestMotor
{
    public partial class Form1 : Form
    {
        private RobotCtrl.DriveCtrl driveCtrl;
        private RobotCtrl.MotorCtrl motorCtrlLeft;
        private RobotCtrl.MotorCtrl motorCtrlRight; 

        public Form1()
        {
            InitializeComponent();
            // Initialisierung DriveCtrl-Objekt
            driveCtrl = new RobotCtrl.DriveCtrl(RobotCtrl.Constants.IODriveCtrl);
            // Initialisierung MotorCtrl_Left-Objekt
            motorCtrlLeft = new RobotCtrl.MotorCtrl(RobotCtrl.Constants.IOMotorCtrlLeft);
            // Initialisierung MotorCtrl_Right-Objekt
            motorCtrlRight = new RobotCtrl.MotorCtrl(RobotCtrl.Constants.IOMotorCtrlRight);

            // DriveCtrl-Objekt wird dem DriveCtlrView-Objekt übergeben
            driveCtrView.DriveCtrl = driveCtrl;
            // MotorCtrlLeft-Objekt wird dem MotorCtrlViewLeft-Objekt übergeben 
            motorCtrViewLeft.MotorCtrl = motorCtrlLeft;
            // MotorCtrlRight-Objekt wird dem MotorCtrlViewRight-Objekt übergeben
            motorCtrlViewRight.MotorCtrl = motorCtrlRight; 
        }
    }
}
