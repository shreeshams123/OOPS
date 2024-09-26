using System;
using System.Collections.Generic;
using System.Text;

namespace Single_Inheritance
{
    internal class Child:Parent
    {
        public Child()
        {
            Console.WriteLine("Constructor of child class");
        }
        static void Main(string[] args)
        {
            Child c = new Child();
            Console.WriteLine(c.id);
            Console.WriteLine(c.name);

        }
    }
}
