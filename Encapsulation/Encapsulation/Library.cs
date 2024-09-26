using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class Library
    {
        string _title;
        string _author;
        string _isbn;
        int _availcopy;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        public string Isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }
        public int AvailCopy
        {
            get { return _availcopy; }
            set
            {
                if (value >= 0)
                {
                    _availcopy = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Available copies cannot be negative.");
                }
            }
        }
        public Library(string title,string author,string isbn,int copy)
        {
            Title = title;
            Author = author;
            Isbn = isbn;
            AvailCopy= copy;
        }
        public void CheckOut()
        {
            if (AvailCopy > 0)
            {
                AvailCopy = AvailCopy - 1;
                Console.WriteLine("Checkout successful");
            }
            else
            {
                throw new ArgumentOutOfRangeException("No available copies");
            }

        }
        public void Return()
        {
            AvailCopy += 1;
            Console.WriteLine("Available copies:"+AvailCopy);
        }
    }
    class Demo
    {
        static void Main(string[] args)
        {
            Library l = new Library("Almond", "Won-Pyung", "100", 2);
            try
            {
                l.CheckOut();
                l.CheckOut();
                l.CheckOut();
               
            }catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            l.Return();
           
        }
    }
}
