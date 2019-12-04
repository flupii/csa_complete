namespace RobotServer
{
    public static class HtmlConst
    {
        public const string HtmlDataContainer = 
            @"<HTML><BODY>" +
            "//Thierry / Mario</br>" +
                "private static void ExecuteDrive()</br>" +
                 "{&emsp; </br>" +
                    "&emsp; float speed = 0.5f;</br>" +
                    "&emsp; float acceleration = 0.3f;</br>" +
                    "&emsp; float distance;</br>" +
                    "&emsp; float angle;</br>" +
                    "&emsp; float radius;</br>" +
                    "&emsp; robot.Drive.Power = true;</br>" +
                    "&emsp; $$Data</br>" +
                "}" +
            "</BODY></HTML>";

        public const string HtmlEmptyContainer =
            @"<HTML><BODY>" +
            "$$Data" +
            "</BODY></HTML>";
    }
}
