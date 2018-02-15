using System;
using System.Collections.Generic;
using System.Linq;

namespace UdemyCSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string input;
            //List<String> list = 
            while (true)
            {
                Console.Write("Input a name : ");
                input = Console.ReadLine();
                if (String.IsNullOrEmpty(input)) break;
            }

            //Console.Write("Input the list of number separated by \",\" :");
            //string input = "";
            //input = Console.ReadLine();

            //List<int> list = input.Split(',').Select(int.Parse).ToList();
            //Console.WriteLine("The maximum of the numbers {0} is {1}", input, list.Max());

            //int i = 0;
            //var random = new Random();
            //i = random.Next(1, 10);
            //bool won = false;

            //Console.WriteLine("The random number is: {0}", i);
            //for (int j = 1; j <=4; j++)
            //{
            //    Console.Write("input integer from 1 to 10: ");
            //    string input = "";
            //    input = Console.ReadLine();
            //    if (input != null)
            //    {
            //        if (i == Convert.ToInt16(input))
            //        {
            //            won = true;
            //            break;
            //        }
            //    }
            //}

            //if (won)
            //{
            //    Console.WriteLine("You won");
            //} else {
            //    Console.WriteLine("You lost"); }

            //int count = 0;
            //for (var i = 1; i<=100; i++)
            //{
            //    if (i%3 == 0)
            //    {
            //        count += 1;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("The numbers count between 1 and 100 are divisible by 3 with no remainder is: {0}", count);

            //int number = 0;
            //int sum = 0;
            //string input = "";
            //while (true)
            //{
            //    Console.Write("Input number or \"ok\" to exit: ");
            //    input = Console.ReadLine();
            //    if (input  == "ok") { break; }
            //    sum = sum + Convert.ToInt16(input);
            //}

            //Console.WriteLine("The sum of all numbers is : {0}", sum);

            //int number = 0;
            //int factor = 1;
            //string input = "";

            //Console.Write("Input number : ");
            //input = Console.ReadLine();

            //if (input != null)
            //{
            //    number = Convert.ToInt16(input);
            //    for (int i = number; i > 0; i--)
            //    {
            //        factor = factor * i;
            //    }
            //    Console.WriteLine(" {0}! = {1}", input, factor);
            //}
            //else {
            //    Console.WriteLine("Nothing to factor."); }
        }
    }
}
