using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InMarTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //LoopNumbers();
            ReverseString();
            Console.ReadLine();

        }

        //section 1 
        //1) Write a program that loops through[1..100]. It should do the following:
        //a) If the number is divisible by 3, print “fizz”.
        //b) If divisible by 5 print “buzz”.
        //c) If divisible by 3 & 5, print “fizzbuzz”.
        public static void LoopNumbers()
        {
            List<decimal> ls_number = new List<decimal>();

            int number = 100;
            for (decimal i = 1; i < number; i++)
            {
                ls_number.Add(i);
                decimal numbevideBy3 = i / 3;
                decimal numbevideBy5 = i / 5;

                if (ls_number.Contains(numbevideBy3) && ls_number.Contains(numbevideBy5))
                {
                    Console.WriteLine("fizzbuzz");
                }
                if (ls_number.Contains(numbevideBy3))
                {
                    Console.WriteLine("fizz");
                }
                if (ls_number.Contains(numbevideBy5))
                {
                    Console.WriteLine("buzz");
                }
            }
        }

        //2) Write a program to reverse a string “abcdef” --> “fedcba” without using the .NET
        //reverse() function
        //Prompt for the input from console and display the output to the console.
        public static void ReverseString()
        {
            string mystring = "abcdef";
            string rev = string.Empty;
            for (int i = mystring.Length-1; i>=0; i--)
            {
                rev += mystring[i];
            }
            Console.WriteLine(rev);

        }



    }
}
