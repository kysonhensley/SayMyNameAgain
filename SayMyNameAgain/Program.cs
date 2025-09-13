//Kyson Hensley
//RCET2265
//Fall 2025
//Hello World Program


using System.ComponentModel.Design;

namespace SayMyNameAgain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type your name.");

            string name = Console.ReadLine();

            
            
            if (name == "Emily")
            {
                Console.WriteLine($"Hello, {name}!");
            }
            else if (name == "Joe")
            {
                Console.WriteLine($"Hello, {name}!");
            }
            else if (name == "Kyson")
            {
                Console.WriteLine("I have the same name as you!");
            }
            else
            {
                Console.WriteLine($"Good Afternoon, {name}!");
            }



            Console.Read();
        }
    }
}
