using System;

namespace BonjourMoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quel est ton nom ? ");
            string nom = Console.ReadLine();

            Console.WriteLine($"Bonjour, {nom} ! Ravi de faire ta connaissance 👋");
            Console.WriteLine("Appuie sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
}