// See https://aka.ms/new-console-template for more information
using System;

namespace Algebra
{
    class Algebra
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();


            */

            Console.WriteLine("What is your name?");
            Console.Write("Type your name here: ");
            string myFirstName = Console.ReadLine();

            string myLastName;
            Console.Write("Type your last name here: ");
            myLastName = Console.ReadLine();

            Console.WriteLine("Nice to meet you! " + myFirstName + " " + myLastName);
            Console.ReadLine();
        }
    }
}