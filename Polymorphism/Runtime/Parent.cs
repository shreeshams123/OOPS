using System;

namespace Runtime
{
    internal class Parent
    {
        public virtual void Test()
        {
            Console.WriteLine("Parent class test method");
        }
    }
    class Child : Parent
    {
        public override void Test()
        {
            Console.WriteLine("Child class test method");
        }
        static void Main(string[] args)
        {
            Parent p = new Child();
            p.Test();
        }
    }
}
