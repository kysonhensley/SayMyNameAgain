

namespace SayMyNameAgain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";

            Console.WriteLine("Please type your name:");
            userInput = Console.ReadLine();

            if (userInput == "Emily" || userInput == "emily" || userInput == "Joe" || userInput == "joe")
            {
                Console.WriteLine("Hello, " + userInput + "! Welcome back!");
            }
            else if (userInput == "Kyson" || userInput == "kyson")
            {
                Console.WriteLine("Your name is awesome! Nice to meet you!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }

            Console.Read();
        }
    }
}
 