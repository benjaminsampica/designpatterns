using System;

namespace CommandPattern.Lights
{
    public class Light
    {
        public void On() => Console.WriteLine("Light was turned on");
        public void Off() => Console.WriteLine("Light was turned off");
    }
}
