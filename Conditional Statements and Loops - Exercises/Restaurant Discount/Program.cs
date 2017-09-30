using System;

namespace Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double hallsprice = 0;
            string hallname = null;
            double packagesprice = 0;
            double discount = 0;

            if (group > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                if (group <= 50)
                {
                    hallsprice = 2500;
                    hallname = "Small Hall";
                }
                else if (group > 50 && group <= 100)
                {
                    hallsprice = 5000;
                    hallname = "Terrace";
                }
                else if (group > 100 && group <= 120)
                {
                    hallsprice = 7500;
                    hallname = "Great Hall";
                }
                switch (package)
                {
                    case "Normal":
                        packagesprice = 500;
                        discount = 0.05;
                        break;
                    case "Gold":
                        packagesprice = 750;
                        discount = 0.10;
                        break;
                    case "Platinum":
                        packagesprice = 1000;
                        discount = 0.15;
                        break;
                }
                double price = hallsprice + packagesprice;
                discount = price * discount;
                double allprice = price - discount;
                double perperson = allprice / group;
                Console.WriteLine($"We can offer you the {hallname}");
                Console.WriteLine($"The price per person is {perperson:F2}$");
            }
        }
    }
}
