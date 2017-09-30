using System;

namespace Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            //bool tr = ;
            int count = 0;
            while (command != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {command}.");
                command = Console.ReadLine();
                count++;
            }
            if (command == "Bake!")
            {
                Console.WriteLine($"Preparing cake with {count} ingredients.");
            }
            
        }
    }
}
