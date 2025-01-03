// i think this is like a package name 
using System.Numerics;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // declare a variable 
            string myFriendsName = "Enter Something";

            Console.WriteLine(myFriendsName);

            String userNAme =  Console.ReadLine();

            Console.WriteLine("Hello "+ userNAme);

            double numOne = 0.0;
            double secondNumber = 0.0;

            while (true) {

                try
                {
                    Console.WriteLine("First Number");
                    numOne = double.Parse(Console.ReadLine());

                    Console.WriteLine("Second Number");
                    secondNumber = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Plese enter a valid number");
                    continue;
                }
            }



            Console.WriteLine("The Sum of Both The Numbers Are " + Math.Round((numOne + secondNumber), 2));

            Console.ReadKey();

        }
    }
}
