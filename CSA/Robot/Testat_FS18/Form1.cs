using RobotCtrl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

/*
 * ToDo:    o Sensorwert auslesen, all 50ms
 *          o Statemachine implementieren, all 50ms nachschauen (Enum schon definiert)
 *          o Anzeige mit Events fertigstellen 
 * 
 * Anforderung: 1. Der Parkvorgang wird mit dem Schalter 1 gestartet.
 *              2. Während dem Parkvorgang blinken alle 4 Led‘s.
 *              3. Nach dem erfolgreichen einparken leuchten alle 4 Led‘s konstant.
 *              4. Der Parkvorgang soll mehrmals mittels Schalter 1 gestartet werden können, ohne das 
 *                 Programm neu auf den Roboter laden zu müssen.
 *              5. Wird keine Parklücke erkannt, soll der Roboter nach einer Fahrstrecke von 3m anhalten. 
 *                 Der Zustand der Led‘s darf frei gewählt werden. 
 * 
 */
namespace Testat_FS18
{
    public partial class Form1 : Form
    {
        #region members
        private RobotCtrl.Robot robot;
        private float noBarrier; 
        private enum State
        {
            IDLE,
            FORWARD,
            PARKING_FIELD_DETECTED,
            PARKING_MANOEUVRES,
            PARKING_MANOEUVRES_COMPLETED,
            PARKING_FIELD_NOT_DETECTED,
            PARKING_FINISHED
        }
        private State fsmState;
        private Thread parkingManoeuverThread;
        private Thread ultrasonicSensorThread;
        #endregion

        #region constructors & destructors
        public Form1()
        {
            InitializeComponent();
            robot = new RobotCtrl.Robot(); // new Robot object

            // --------- Initialization --------- 
            // Drive
            robot.Drive.Power = true; // Motor power ON
            driveView.Drive = robot.Drive;
            runArcView.Drive = robot.Drive;
            runTurnView.Drive = robot.Drive;
            runLineView.Drive = robot.Drive;
            // Initalization for the Start
            commonRunParameters_AccelerationChanged(null, EventArgs.Empty);
            commonRunParameters_SpeedChanged(null, EventArgs.Empty);

            // LED view
            consoleView.Console = robot.RobotConsole;
            robot.RobotConsole[Switches.Switch1].SwitchStateChanged += (s, e) => { robot.RobotConsole[Leds.Led1].LedEnabled = robot.RobotConsole[Switches.Switch1].SwitchEnabled; };
            robot.RobotConsole[Switches.Switch2].SwitchStateChanged += (s, e) => { robot.RobotConsole[Leds.Led2].LedEnabled = robot.RobotConsole[Switches.Switch2].SwitchEnabled; };
            robot.RobotConsole[Switches.Switch3].SwitchStateChanged += (s, e) => { robot.RobotConsole[Leds.Led3].LedEnabled = robot.RobotConsole[Switches.Switch3].SwitchEnabled; };
            robot.RobotConsole[Switches.Switch4].SwitchStateChanged += (s, e) => { robot.RobotConsole[Leds.Led4].LedEnabled = robot.RobotConsole[Switches.Switch4].SwitchEnabled; };
            robot.RobotConsole[Switches.Switch1].SwitchStateChanged += StartParkingManoveur;

            // Radar view
            radarView.Radar = robot.Radar;

            // FSM state
            fsmState = State.IDLE;

            // Parking status
            label_ParkingState.Text = "Bereit zum starten";

            // No barrier value
            noBarrier = 0.0f; 

            // Thread Initalization
            
            ultrasonicSensorThread = new Thread(UltrasonicRead);
        }
        #endregion

        public void UpdateParkingState(string s)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(UpdateParkingState), s);
            }
            else
            {
                label_ParkingState.Text = s;
            }
        }

        private void ParkingFSM()
        {
            bool oldSwitchState = false;
            int countFieldDetection = 0;

            while (true)
            {
                switch (fsmState)
                {
                    case State.IDLE:
                        // Check until switch 1 is detected
                        countFieldDetection = 0;
                        label_ParkingState.Text = "Vorwärts";
                        if (robot.RobotConsole[Switches.Switch1].SwitchEnabled && !oldSwitchState)
                        {
                            fsmState = State.FORWARD;
                            oldSwitchState = true;
                            noBarrier = robot.Radar.Distance + 0.1f;
                        }
                        break;

                    case State.FORWARD:
                        /* The us view always the same distance until a empty field is detected. After thath it's will 
                         * be calculated if the parkfield is optimal for the Robot.
                         */                      
                        this.robot.Drive.RunLine(3, commonRunParameters.Speed, 0.3f);
                        fsmState = State.PARKING_FIELD_DETECTED;
                        break;

                    case State.PARKING_FIELD_DETECTED:
                        if (robot.Drive.MotorCtrlLeft.Distance >= 2.8f)
                        {
                            robot.Drive.Stop();
                            fsmState = State.PARKING_FIELD_NOT_DETECTED;
                        }

                        if (noBarrier <  (robot.Radar.Distance ))
                        {
                            countFieldDetection++;
                            if(countFieldDetection == 15)
                            {
                                fsmState = State.PARKING_MANOEUVRES;
                                robot.Drive.Stop();
                            }
                        }
                        else
                        {
                            countFieldDetection = 0; 
                        }
                        break;

                    case State.PARKING_MANOEUVRES:
                        robot.Drive.RunTurn(90.0f, 0.5f, 0.3f);
                        fsmState = State.PARKING_MANOEUVRES_COMPLETED;
                        break;

                    case State.PARKING_MANOEUVRES_COMPLETED:
                        Thread.Sleep(2000);
                        robot.Drive.RunLine(-noBarrier - 0.33f, 0.5f, 0.3f);
                        fsmState = State.PARKING_FINISHED;
                        
                        break;

                    case State.PARKING_FINISHED:
                        if (robot.Drive.Done)
                        {
                            robot.Drive.Stop();
                            fsmState = State.IDLE;
                            parkingManoeuverThread.Abort();
                            oldSwitchState = false;
                        }
                        break;

                    case State.PARKING_FIELD_NOT_DETECTED:
                        break;

                    default:
                        break;
                }
                Thread.Sleep(50); // 50ms sleep
            }
        }

        private void UltrasonicRead()
        {
            float distance = 0.0f;
            while (true)
            {
                distance = robot.Radar.Distance;
                Thread.Sleep(50); // 50ms sleep
            }
        }

        private void StartParkingManoveur(object sender, EventArgs e)
        {
            if (robot.RobotConsole[Switches.Switch1].SwitchEnabled)
            {
                parkingManoeuverThread = new Thread(ParkingFSM);
                parkingManoeuverThread.Start();
                //ultrasonicSensorThread.Start();
            }

        }

        private void commonRunParameters_AccelerationChanged(object sender, EventArgs e)
        {
            runLineView.Accleration = commonRunParameters.Acceleration;
            runTurnView.Acceleration = commonRunParameters.Acceleration;
            runArcView.Accleration = commonRunParameters.Acceleration;
        }

        private void commonRunParameters_SpeedChanged(object sender, EventArgs e)
        {
            runLineView.Speed = commonRunParameters.Speed;
            runTurnView.Speed = commonRunParameters.Speed;
            runArcView.Speed = commonRunParameters.Speed;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            robot.Drive.Stop();
        }

        private void buttonHalt_Click(object sender, EventArgs e)
        {
            robot.Drive.Halt();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
