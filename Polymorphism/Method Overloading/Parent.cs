using System;
using System.Runtime.InteropServices;

namespace Method_Overloading
{
    internal class Parent
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("First method");
            Console.WriteLine(a + b);
        }
        public string Add(string s1, string s2)
        {
            Console.WriteLine("Second method");
            return s1 + s2;
        }
    }

    class Child : Parent { 
       public string Add(int a,string s)
        {
            Console.WriteLine("Third method");
            return a+s;
        }
        static void Main(string[] args)
        {
            Child p=new Child();
            Add(2, 3);
            Console.WriteLine(p.Add("Hello", " World"));
            Console.WriteLine(p.Add(2, "Monica"));
        }
    }
}
