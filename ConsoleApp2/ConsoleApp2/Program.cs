using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
             Console.WriteLine("İsminizi giriniz");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba" + name + " " + surname);

        }
    }
}
