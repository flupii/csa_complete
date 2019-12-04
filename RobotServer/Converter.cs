namespace RobotServer
{
    public static class Converter
    {
        public static string Convert(Command cmd)
        {
            switch (cmd.Action)
            {
                case Commands.TrackLine:
                    return "robot.Drive.RunLine(distance, speed, acceleration);";
                case Commands.TrackTurnLeft:
                    return "robot.Drive.RunTurn(angle, speed, acceleration);";
                case Commands.TrackTurnRight:
                    return "robot.Drive.RunTurn(-1*angle, speed, acceleration);";
                case Commands.TrackArcLeft:
                    return "robot.Drive.RunArcLeft(radius, angle, speed, acceleration);";
                case Commands.TrackArcRight:
                    return "robot.Drive.RunArcLeft(radius, angle, speed, acceleration);";
                default:
                    return "";
            }
        }
    }
}
