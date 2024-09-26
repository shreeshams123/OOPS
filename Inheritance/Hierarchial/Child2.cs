using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchial
{
    internal class Child2:Parent
    {
        public double salary = 50000;
        static void Main(string[] args)
        {
            Child2 c2=new Child2();
            Console.WriteLine(c2.id);
            Console.WriteLine(c2.salary);
        }
    }
}
