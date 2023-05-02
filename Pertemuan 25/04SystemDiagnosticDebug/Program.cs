

using System.Diagnostics;

namespace SystemDiagnosticDebug
{
    public class Program
    {
        static void Main()
        {
            string logpath = "myDebuglog.log";
            Trace.Listeners.Add(new TextWriterTraceListener(logpath));
            Trace.AutoFlush = true;
            Trace.Listeners.Remove ("Default"); //remove defalt listener

            Trace.WriteLine ("Starting rbot arm program");
       
            int i = 0;
            RobotArm arm = new RobotArm();
            while (i<10000)
            {
                arm.Connect();
                arm.MoveTo(0,0,0);
                arm.Grab();
                arm.MoveTo(10,10,10);
                arm.Release();
                arm.Disconnect();
                i++;
            }
            Trace.WriteLine ("Robot arm program finished");
            Trace.Close();
        }
    }
}
