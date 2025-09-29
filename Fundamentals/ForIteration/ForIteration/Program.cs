Using System;
namespace ForIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
              //  Console.WriteLine(i); // It looks exactly the same as Java! 
              if (i == 7){
                Console.WriteLine("Found Seven!");
                break; // breaks out of the loop
              }
            
            } 
            Console.ReadLine();
        }
    }
}