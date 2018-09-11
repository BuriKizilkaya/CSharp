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
    public partial class ConsoleView : UserControl
    {
        private RobotCtrl.RobotConsole console;

        public ConsoleView()
        {
            InitializeComponent();
        }

        #region properties
        public RobotCtrl.RobotConsole Console
        {
            get
            {
                return console;
            }

            set
            {
                console = value; 
                if(console != null)
                {
                    // LEDs zuweisen
                    this.ledView1.Led = console[RobotCtrl.Leds.Led1];
                    this.ledView2.Led = console[RobotCtrl.Leds.Led2];
                    this.ledView3.Led = console[RobotCtrl.Leds.Led3];
                    this.ledView4.Led = console[RobotCtrl.Leds.Led4];

                    // Switches zuweisen
                    this.switchView1.Myswitch = console[RobotCtrl.Switches.Switch1];
                    this.switchView2.Myswitch = console[RobotCtrl.Switches.Switch2];
                    this.switchView3.Myswitch = console[RobotCtrl.Switches.Switch3];
                    this.switchView4.Myswitch = console[RobotCtrl.Switches.Switch4];
                }
            }
        }
        #endregion


    }
}