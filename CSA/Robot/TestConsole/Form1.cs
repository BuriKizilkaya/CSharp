using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RobotView;
using RobotCtrl;
using RobotIO;

namespace TestConsole
{
    public partial class Form1 : Form
    {
        private RobotCtrl.RobotConsole robotConsole;

        public Form1()
        {
            InitializeComponent();
            robotConsole = new RobotConsole();
            consoleView.Console = robotConsole;

            robotConsole[Switches.Switch1].SwitchStateChanged += (s, e) => { robotConsole[Leds.Led1].LedEnabled = robotConsole[Switches.Switch1].SwitchEnabled; };
            robotConsole[Switches.Switch2].SwitchStateChanged += (s, e) => { robotConsole[Leds.Led2].LedEnabled = robotConsole[Switches.Switch2].SwitchEnabled; };
            robotConsole[Switches.Switch3].SwitchStateChanged += (s, e) => { robotConsole[Leds.Led3].LedEnabled = robotConsole[Switches.Switch3].SwitchEnabled; };
            robotConsole[Switches.Switch4].SwitchStateChanged += (s, e) => { robotConsole[Leds.Led4].LedEnabled = robotConsole[Switches.Switch4].SwitchEnabled; };
        }
    }
}
