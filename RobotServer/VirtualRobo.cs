namespace RobotServer
{
    public class VirtualRobo
    {
        const float SPEED = 0.5f;
        const float ACCE = 0.3f;

        //public static Drive Drive = new Drive();
        
        public void Start() { }
        //{
        //    Drive.Power = true;
        //    foreach (var item in InternalStorage.Commands)
        //    {
        //        switch (item.Action)
        //        {
        //            case Commands.TrackLine:
        //                Drive.RunLine(item.ValueL, SPEED, ACCE);
        //                break;
        //            case Commands.TrackTurnLeft:
        //                Drive.RunTurn(item.ValueA, SPEED, ACCE);
        //                break;
        //            case Commands.TrackTurnRight:
        //                Drive.RunTurn(item.ValueA * -1, SPEED, ACCE);
        //                break;
        //            case Commands.TrackArcLeft:
        //                Drive.RunArcLeft(item.ValueL, item.ValueA, SPEED, ACCE);
        //                break;
        //            case Commands.TrackArcRight:
        //                Drive.RunArcRight(item.ValueL, item.ValueA, SPEED, ACCE);
        //                break;
        //            case Commands.Start:
        //                break;
        //            default:
        //                break;
        //        }
        //        Thread.Sleep(1000);
        //    }
        //    Drive.Power = false;
        //    InternalStorage.Commands.Clear();
        //}
    }
}
