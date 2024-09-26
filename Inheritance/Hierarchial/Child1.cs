using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchial
{
    internal class Child1:Parent
    {
        public string name="Rachael";
        static void Main(string[] args)
        {
            Child1 c1= new Child1();
            Console.WriteLine(c1.id);
            Console.WriteLine(c1.name);
        }
    }
    
}
