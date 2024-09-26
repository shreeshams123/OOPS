using System;

namespace Operator_Overloading
{
    internal class Program
    {
        
        int y;
        string z;
        Program(int y,string z)
        {
            
            this.y = y;
            this.z = z;
        }
        public static int operator +(int x,Program p){
            return x + p.y;
            }
        public static string operator +(string x, Program p)
        {
            return x+p.z;
        }
        static void Main(string[] args)
        {
            Program p = new Program(2,"alex");
            Console.WriteLine("Hii " + p);
            Console.WriteLine(3 + p);
        }
    }
}
