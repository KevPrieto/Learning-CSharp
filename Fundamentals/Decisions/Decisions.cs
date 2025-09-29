using System;
using System.Runtime.Serialization;

namespace Decisions
{
    class Decisions
    {
        static void Main(string[] args)
        { /*
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();
            string message = "";

            if (userValue == "1")
                message = "You won a new car!";

            else if (userValue == "2")
                message = "You won a new boat!";
            else if (userValue == "3")
                message = "You won a new cat!";
            else
            {
                message = "Sorry, we didn't understand.";
                message += "You lose... :(";


            }
            Console.WriteLine(message);
            Console.ReadLine();
            */

            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "brand new BMW!" : "brand new Toyota!";
            /*
            Console.Write("You won a ");
            Console.Write(message);
            Console.ReadLine();
            */

            Console.WriteLine("You entered: {0}, therefore you won a {1}", userValue, message);
            Console.ReadLine();
  

        }

    }
}