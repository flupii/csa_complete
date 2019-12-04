using RobotCtrl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TestDrive
{
    public partial class Form1 : Form
    {
        #region members
        private Robot robot;
        #endregion


        #region constructor & destructor
        public Form1()
        {
            InitializeComponent();

            robot = new Robot();        // neuen Roboter erstellen
            robot.Drive.Power = true;   // Stromversorgung der Motoren (im DriveCtrl) einschalten

            driveView1.Drive = robot.Drive; // DriveView benötigt Drive-Objekt zur Visualisierung
            runLine1.Drive = robot.Drive; // RunLine benötigt Drive zum Aufruf von Drive.RunLine(...)
            runTurn1.Drive = robot.Drive;
            runArc1.Drive = robot.Drive;
            radarView1.Radar = robot.Radar;
            consoleView1.RobotConsole = robot.RobotConsole;

            commonRunParameters1.AccelerationChanged += AccelerationChanged;
            commonRunParameters1.SpeedChanged += SpeedChanged;

            SpeedChanged(null, EventArgs.Empty); // Default Wert setzen
            AccelerationChanged(null, EventArgs.Empty); // Default Wert setzen

            // Events der Konsolenschalter registrieren
            robot.RobotConsole[Switches.Switch1].SwitchStateChanged += SwitchStateChanged;
            robot.RobotConsole[Switches.Switch2].SwitchStateChanged += SwitchStateChanged;
            robot.RobotConsole[Switches.Switch3].SwitchStateChanged += SwitchStateChanged;
            robot.RobotConsole[Switches.Switch4].SwitchStateChanged += SwitchStateChanged;
        }
        #endregion


        #region methods
        private void SpeedChanged(object sender, EventArgs e)
        {
            runLine1.Speed = commonRunParameters1.Speed;
            runTurn1.Speed = commonRunParameters1.Speed;
            runArc1.Speed = commonRunParameters1.Speed;
        }
        private void AccelerationChanged(object sender, EventArgs e)
        {
            runLine1.Acceleration = commonRunParameters1.Acceleration;
            runTurn1.Acceleration = commonRunParameters1.Acceleration;
            runArc1.Acceleration = commonRunParameters1.Acceleration;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            robot.Drive.Stop();
        }

        private void buttonHalt_Click(object sender, EventArgs e)
        {
            robot.Drive.Halt();
        }

        void SwitchStateChanged(object sender, SwitchEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new EventHandler<SwitchEventArgs>(SwitchStateChanged), sender, e);
            }
            else
            {
                switch (e.Swi)
                {
                    case Switches.Switch1:
                        runLine1.Start();
                        break;

                    case Switches.Switch2:
                        runTurn1.Start();
                        break;

                    case Switches.Switch3:
                        runArc1.Start();
                        break;

                    case Switches.Switch4:
                        Exit();
                        break;
                }
            }
        }

        private void Exit()
        {
            //try
            //{
            //    Process p = new Process();
            //    p.StartInfo.FileName = @"\CompactFlash\FtpRoot\x86\CMAccept.exe";
            //    p.Start();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}
            robot.RobotConsole[Leds.Led1].LedEnabled = true;
            robot.RobotConsole[Leds.Led2].LedEnabled = true;
            robot.RobotConsole[Leds.Led3].LedEnabled = true;
            robot.RobotConsole[Leds.Led4].LedEnabled = true;
            System.Windows.Forms.Application.Exit();
        }
        
        private void timerCheckRadar_Tick(object sender, EventArgs e)
        {
           // if (robot.Radar.Distance < 0.3f) robot.Drive.Stop();
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
