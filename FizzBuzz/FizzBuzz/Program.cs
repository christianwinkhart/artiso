using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            //FizzBuzz();
             Moneychanger();
            Console.ReadKey();

        }
        private static void Moneychanger()
        {

            List<int> Scheine = new List<int>()
            {
                500,
                200,
                100,
                50,
                20,
                10,
                5,
                2,
                1
            };
            Console.WriteLine("Moneychanger");

            while (true)
            {
                Console.Write("enter a number:");
                string input = Console.ReadLine();
                bool success = Int32.TryParse(input, out int money);
                for (int i = 0; i < Scheine.Count; i++)
                {
                    if (money >= Scheine[i])
                    {
                        int geteilt = (money / Scheine[i]);
                        money = (money - (geteilt * Scheine[i]));
                        Console.WriteLine($"{geteilt} x {Scheine[i]}$");
                    }
                }
            }
        }

        private static void FizzBuzz()
        {
            for (int number = 1; number <= 100; number++)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");

                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else Console.WriteLine(number);


            }
        }
    }
}






