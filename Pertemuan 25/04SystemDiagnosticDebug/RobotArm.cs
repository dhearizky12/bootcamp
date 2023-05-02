
using System.Diagnostics;

namespace SystemDiagnosticDebug;

public class RobotArm
{
    public void Connect()
    {
        Debug.WriteLine("Connecting to Robot Arm");
        //code to connect to robot arm
    }
    public void MoveTo(int x, int y, int z)
    {
        Debug.WriteLine($"Moving robot arm to ({x}, {y}, {z})");
        // code to move robot arm to specified position
    }
    public void Grab()
    {
        Debug.WriteLine("Grabbig object with robot arm");
        //code to grab object with robot arm
    }
    public void Release()
    {
        Debug.WriteLine("Releasing object with robot arm");
        //code to release object with robot arm
    }
    public void Disconnect()
    {
        Debug.WriteLine("Disconnecting from robot arm");
    }
}
