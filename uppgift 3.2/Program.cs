using System;
namespace Uppgift_3._2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasie");
            string X = Console.ReadLine();
            if (X == "J")
            {
                Console.WriteLine("Hur gammal är du?");
            }
            int ålder = int.Parse(Console.ReadLine());
            if (ålder < 22)
            {
                Console.WriteLine("vi erbjuder dig ett jobb!");
            }
            else if (ålder > 22)
            {
                Console.WriteLine("vi erbjuder inte dig ett jobb");
            }
        }
    }
}

