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
    public partial class LEDView : UserControl
    {
        #region attributes
        private bool state;
        private Led led;
        #endregion

        #region properties
        public bool State
        {
            get
            {
                return state; 
            }  

            set
            {
                state = value;
                pictureBox1.Image = (value ? Resource.LedOn : Resource.LedOff); // Spezial Variante von einer IF-Anweisung
            }
        }

        public Led Led
        {
            get
            {
                return led;
            }

            set
            {
                led = value;
                if (led != null) led.LedStateChanged += Led_LedStateChanged;
            }
        }
        #endregion

        #region constructors
        public LEDView()
        {
            InitializeComponent();
            State = false; 
        }
        #endregion

        #region methods
        private void Led_LedStateChanged(object sender, LedEventArgs e)
        {
            //Prüfen ob Aufrufer == GUI-Thread
            if (InvokeRequired)
            {
                //Aufrufer ist nicht der GUI-Thread => Synchronisation notwendig!
                //Wartet bis die Message durch die Queue gegangen ist und abgearbeitet wurde
                Invoke(new EventHandler<LedEventArgs>(Led_LedStateChanged), sender, e);
                //BeginInvoke(...) würde nur die Message eintragen
            }
            else { State = e.LedEnabled; } //Aufrufer ist der GUI-Thread
        }
        #endregion

    }
}