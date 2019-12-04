using System;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Threading;

namespace RobotServer
{
    public class TcpHandler
    {
        private TcpClient client;

        public TcpHandler(TcpClient _client)
        {
            client = _client;
        }

        public void HandleRequest()
        {
            using (StreamReader sr = new StreamReader(client.GetStream()))
            {
                string command = sr.ReadToEnd();
                var a = command.Split(new[] { '\n' });
                var b = a.Where(o => o != string.Empty);
                foreach (var item in b)
                {
                    var splitter = item.Split(new[] { '+' });
                    Command cmd = new Command();
                    cmd.Action = (Commands)Enum.Parse(typeof(Commands), splitter[0], true);
                    switch (cmd.Action)
                    {
                        case Commands.TrackLine:
                            cmd.ValueA = float.Parse(splitter[1]);
                            break;
                        case Commands.TrackTurnLeft:    
                        case Commands.TrackTurnRight:
                            cmd.ValueA = float.Parse(splitter[1]);
                            break;
                        case Commands.TrackArcLeft:
                            cmd.ValueA = float.Parse(splitter[1]);
                            cmd.ValueL = int.Parse(splitter[2]);
                            break;
                        case Commands.TrackArcRight:
                            cmd.ValueA = float.Parse(splitter[1]);
                            cmd.ValueL = int.Parse(splitter[2]);
                            break;
                        case Commands.Start:
                            VirtualRobo robo = new VirtualRobo();
                            new Thread(robo.Start).Start();
                            break;
                        default:
                            break;
                    }
                    InternalStorage.Commands.Add(cmd); //Sperren ?
                }
            }
        }
    }
}
