using System;

namespace Castle.Test.AOP
{
    public class Person
    {
        public virtual void SayHello()
        {
            Console.WriteLine("Hello");
        }

        public void SayHi()
        {
            Console.WriteLine("Hi");
        }
    }
}