using System;
using System.Collections.Generic;
using System.Text;

namespace Multi_Level
{
    internal class Class2:Class1
    {
        public Class2(int id) : base("Alex")
        {
            this.id = id;
            Console.WriteLine("Constructor of class 2");
        }
        public int id;
    }
}
