using System;

namespace PizzaOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            var expr = true;
            Console.Write("Hello");
            var user = Console.ReadLine();
            expr = user switch
            {
                "yes" => false,
                _ => true,
            };
            if (expr == true)
            {
                Console.WriteLine("Hello World!");
                Console.Write("Hello");

                Console.Write("Sto");
            }
            else
            {
                Console.Clear();
            }

           
        }
    }
}
