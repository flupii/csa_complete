namespace RobotServer
{
    public class Command
    {
        public Commands Action { get; set; }
        public float ValueA { get; set; }
        public int ValueL { get; set; }

        public override string ToString()
        {
            return Converter.Convert(this);
        }
    }
}
