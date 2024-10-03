using System;
namespace Uppgift_2_._4
{
 class Program
      {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad är din lön");
            int lön1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Vad är din lön");
            int lön2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Vad är din lön");
            int lön3 = int.Parse(Console.ReadLine());

            int medelvärde = (lön1 + lön2 + lön3) / 3;
            Console.WriteLine("Medelvärdet är " + medelvärde);


        }









    }
}