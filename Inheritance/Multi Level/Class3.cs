using System;
using System.Collections.Generic;
using System.Text;

namespace Multi_Level
{
    internal class Class3:Class2
    {
        Class3(int i):base(i)
        {
            Console.WriteLine("Constructor of class 3");
        }
        static void Main(string[] args)
        {
            Class3 c = new Class3(10);
            Console.WriteLine(c.id);
            Console.WriteLine(c.name);
        }
    }
}
