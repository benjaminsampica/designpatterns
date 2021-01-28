using CommandPattern.GarageDoors;
using CommandPattern.Lights;

namespace CommandPattern
{
    public class RemoteControlTest
    {
        public void TestController()
        {
            var remoteControl = new RemoteControl();

            var garageDoor = new GarageDoor();
            remoteControl.SetCommand(0, new GarageDoorOpenCommand(garageDoor), new GarageDoorCloseCommand(garageDoor));

            var light = new Light();
            remoteControl.SetCommand(1, new LightOnCommand(light), new LightOffCommand(light));

            remoteControl.OnButtonWasPressed(0);
            remoteControl.OffButtonWasPressed(0);
            remoteControl.OnButtonWasPressed(1);
            remoteControl.OffButtonWasPressed(1);
        }
    }
}
