using System;
using System.ComponentModel.Design;

namespace Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int stoper = int.Parse(Console.ReadLine());
            int calories = 0;
            for (int i = 1; i <= stoper; i++)
            {
                string ingredients = Console.ReadLine().ToLower();
                switch (ingredients)
                {
                    case "cheese": calories = calories + 500; break;
                    case "tomato sauce": calories = calories + 150; break;
                    case "salami": calories = calories + 600; break;
                    case "pepper": calories = calories + 50; break;
                    default: calories = calories + 0; break;
                }

            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
