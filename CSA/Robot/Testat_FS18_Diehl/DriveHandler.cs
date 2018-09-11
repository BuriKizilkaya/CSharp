using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Testat_FS18_Diehl
{
    class DriveHandler
    {
        private FileServer fileServer;
        private PositionHandler positionHandler;
        private RobotCtrl.Robot robot;
        private Thread doMeasurments;
        private Thread doCommands;
        private const float speed = 5.0f;
        private const float accelaration = 0.3f;


        public DriveHandler()
        {
            fileServer = new FileServer();
            robot = new RobotCtrl.Robot();
            positionHandler = new PositionHandler(robot, fileServer);

            // RoboterInitializiation
            robot.Drive.Power = true; // Motor power ON
                        
            // Threads
            doMeasurments = new Thread(positionHandler.DoMeasurments);
            doCommands = new Thread(DoCommands);
            doCommands.Start();
        }

        private void DoCommands()
        {
            string[] commands;
            float valueA;
            float valueL;

            // Start the Fileserver
            fileServer.StartServer();

            // Start the Measurment-Thread
            doMeasurments.Start();

            while (true)
            {
                // check has the roboter finished the actually Move and StartInstruction is true
                if (robot.Drive.Done && fileServer.StartInstruction)
                {
                    // check is the List empty
                    if (fileServer.DriveInstructions.Count != 0)
                    {
                        commands = ((String)fileServer.DriveInstructions[0]).Split(' ');
                        fileServer.DriveInstructions.RemoveAt(0);

                        Console.WriteLine(robot.Drive.Position.X +"" );
                        Console.WriteLine(robot.Drive.Position.Y + "");
                        // check what for command is
                        switch (commands[0])
                        {
                            case "TrackLine":
                                valueL = float.Parse(commands[1]);
                                robot.Drive.RunLine(valueL, speed, accelaration);
                                break;

                            case "TrackTurnLeft":
                                valueA = float.Parse(commands[1]);
                                robot.Drive.RunTurn(valueA, speed, accelaration);
                                break;

                            case "TrackTurnRight":
                                valueA = (-1) * float.Parse(commands[1]);
                                robot.Drive.RunTurn(valueA, speed, accelaration);
                                break;

                            case "TrackArcLeft":
                                valueA = float.Parse(commands[1]);
                                valueL = float.Parse(commands[2]);
                                robot.Drive.RunArcLeft(valueL, valueA, speed, accelaration);
                                break;

                            case "TrackArcRight":
                                valueA = float.Parse(commands[1]);
                                valueL = float.Parse(commands[2]);
                                robot.Drive.RunArcRight(valueL, valueA, speed, accelaration);
                                break;

                            case "Start":
                                break;

                            default:
                                Console.WriteLine("No Track-CMD!");
                                break;
                        } 
                    }
                    // check is the list null and the last drive is finished
                    else if (robot.Drive.Done && (fileServer.DriveInstructions.Count == 0))
                    {
                        positionHandler.MeasurmentFinished = true;
                    }
                }
                // delete the commands-Buffer
                commands = null;

                Thread.Sleep(1);
            }
        } // end DoCommands()


        // Application Start
        static void Main(string[] args)
        {
            DriveHandler driveHandler = new DriveHandler();
            HttpServer httpServer = new HttpServer();
            httpServer.StartServer();
        }

    }
}
