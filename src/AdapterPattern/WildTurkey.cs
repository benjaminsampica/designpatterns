using System;

namespace AdapterPattern
{
    public class WildTurkey : ITurkey
    {
        public void Gobble()
        {
            Console.WriteLine("I gobble.");
        }

        public void Fly()
        {
            Console.WriteLine("I fly.");
        }
    }

    public interface ITurkey
    {
        void Fly();
        void Gobble();
    }
}
