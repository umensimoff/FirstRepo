﻿using System;

namespace Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            double price = 0;
            switch (profession)
            {
                case "Athlete":
                    price = 0.70;
                    break;
                case "Businessman":
                case "Businesswoman":
                    price = 1.00;
                    break;
                case "SoftUni Student":
                    price = 1.70;
                    break;
                default:
                    price = 1.20;
                    break;
            }
            totalPrice = quantity * price;
            Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
        }
    }
}
