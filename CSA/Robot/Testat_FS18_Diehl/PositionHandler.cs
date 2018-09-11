using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading;
using System.IO;

namespace Testat_FS18_Diehl
{
    class PositionHandler
    {
        private ArrayList measurments; 
        private RobotCtrl.Robot robot;
        private FileServer fileServer;
        private bool measurmentFinished;

        public PositionHandler(RobotCtrl.Robot robot, FileServer fs)
        {
            measurments = new ArrayList();
            this.robot = robot;
            this.fileServer = fs;
            measurmentFinished = false;
        }


        public void DoMeasurments()
        {
            while (true)
            {
                if (measurmentFinished)
                {
                    MakeLogFile();
                }
                else
                {
                    AddInList(robot.Position.X, robot.Position.Y);
                }

                Thread.Sleep(100); // do measurment every 10ms
            }
            
        }
        
        public ArrayList Measurments
        {
            get
            {
                return measurments;
            }
        }

        public bool MeasurmentFinished
        {
            get
            {
                return measurmentFinished;
            }
            set
            {
                measurmentFinished = value;
            }
        }

        private void AddInList(float xPosition, float yPosition)
        {
            string measurmentLine = DateTime.Now.ToString("dd.MM.yyyy-hh:mm:ss.fff") + ";" + xPosition.ToString() + ";" + yPosition.ToString();
            measurments.Add(measurmentLine);
        }

        private void MakeLogFile()
        {
            // check is the list empty
            if (measurments.Count != 0)
            {
                StreamWriter writer = null;
                try
                {
                    FileStream fs = new FileStream("PositionLog.txt", FileMode.Create, FileAccess.Write);
                    writer = new StreamWriter(fs);

                    writer.WriteLine("Team 5");
                    // write and delete until the list is empty
                    while (measurments.Count != 0)
                    {
                        writer.WriteLine(measurments[0]);
                        Console.WriteLine(measurments[0]);
                        measurments.RemoveAt(0);
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    writer.Close();
                } 
            }
        }
        
    }
}
