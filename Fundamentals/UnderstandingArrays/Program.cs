using System;
namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize an array of integers
            int[] numbers = new int[5];

            // Assign values to the array elements
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            // Access and print the array elements
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Element at index {i}: {numbers[i]}");
            }

            // Demonstrate array length property
            Console.WriteLine($"The length of the array is: {numbers.Length}");

            string[] names = new string[] { "Kevin", "Marco", "Caesar" };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Element at index {i}, is {names[i]}");
            }

            foreach (string name in names)
            {
                Console.WriteLine($"Hello, {name}!");
            }

            string zig = "You can get what you want of life " +
            "if you help enough other people get what they want.";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray) {
                Console.Write(zigChar);
            }
        }

        
    }
}