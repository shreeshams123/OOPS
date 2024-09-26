using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example
{
    internal interface IProduct
    {
        void CalculatePrice(int a);
        static void DisplayDiscount()
        {
            Console.WriteLine("Discount on clothing if quantity is more than 5");
        }
    }
    class Electronics:IProduct
    {
       
        int price;
        int delivery;
        public Electronics( int price, int delivery)
        {
            
            this.price = price;
            this.delivery = delivery;
        }
        public void CalculatePrice(int quantity)
        {
            double total = (price + delivery) * quantity;
            
            Console.WriteLine("The total price is " + total);

        }

    }
    class Clothing : IProduct
    {
        public int price;
        public int delivery;
        public int quantity;
        public Clothing( int price, int delivery)
        {
            this.price = price;
            this.delivery = delivery;
            
        }
        public void CalculatePrice(int quantity)
        {
            double total = (price + delivery) * quantity;
            if (quantity > 5)
            {
                total = total * 10 / 100;
                
                Console.WriteLine("Total price is" + total);
            }
            else
            {
                Console.WriteLine("Total price is" + total);
            }
        }
        public static void DisplayDiscount()
        {
            Console.WriteLine("10% discount applied on clothing items");
        }

    }
    class Demo
    {
        static void Main(string[] args)
        {
            IProduct.DisplayDiscount();
            Electronics e = new Electronics(500,50);
            e.CalculatePrice(5);
            Clothing c = new Clothing(500, 50);
            c.CalculatePrice(6);
            Clothing.DisplayDiscount();
           
            
        }
    }
}
