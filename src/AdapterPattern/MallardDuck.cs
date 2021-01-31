using System;

namespace AdapterPattern
{
    public class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("I fly.");
        }

        public void Quack()
        {
            Console.WriteLine("I quack.");
        }
    }

    public interface IDuck
    {
        void Fly();
        void Quack();
    }
}
