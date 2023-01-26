using System;
namespace Uppgift_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] xtal = new string[3];


            xtal[0] = "2";
            xtal[1] = "3";
            Console.WriteLine("skriv tredje talet");
            xtal[2] = Console.ReadLine();

            Console.WriteLine($"{xtal[0]}, {xtal[1]} och {xtal[2]} ");



        }
    }
}