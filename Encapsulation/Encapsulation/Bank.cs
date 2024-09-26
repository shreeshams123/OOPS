using System;

namespace Encapsulation
{
    public class Bank
    {
        private int _id;
        private bool _status;
        private double _balance;
        public Bank(int id, bool status, double balance)
        {
            Id = id;
            Status= status;
            Balance = balance;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public bool Status
        {
            get
            {
                if (_status == true)
                { 
                Console.WriteLine("Account activated");
                return _status;
                }
                else
                {
                    Console.WriteLine("Account deactivated");
                    return _status;
                }
        }
            set { _status = value; }
        }
        public double Balance
        {

            get
            {
                if (Status == true)
                    return _balance;
                else
                {
                    
                    return 0;
                }
            }
            set { _balance = value; }
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Bank b = new Bank(20, false, 5000);
            Console.WriteLine(b.Id);
            Console.WriteLine(b.Status);
            Console.WriteLine(b.Balance);
            b.Status = true;
            Console.WriteLine(b.Balance);


        }
    }
}
