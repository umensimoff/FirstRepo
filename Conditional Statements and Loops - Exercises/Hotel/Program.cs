using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightscount = int.Parse(Console.ReadLine());
            //discount = 0;
            double pricestudio = 0;
            double pricedouble = 0;
            double pricesuite = 0;

            switch (month)
            {
                case "May":
                case "October":
                    if (nightscount > 7)
                    {
                        if (month == "May")
                        {
                            double discount = 0.95;
                            pricestudio = 50 * discount * nightscount;
                        }
                        else if (month == "October")
                        {
                            pricestudio = 50 * (nightscount - 1);
                        }
                    }
                    else
                    {
                        pricestudio = 50 * nightscount;
                    }
                    pricedouble = 65 * nightscount;
                    pricesuite = 75 * nightscount;
                    break;
                case "June":
                case "September":
                    if (nightscount > 7 && month == "September")
                    {
                        pricestudio = 60 * (nightscount - 1);
                    }
                    else
                    {
                        pricestudio = 60 * nightscount;

                    }
                    if (nightscount > 14)
                    {
                        double discount = 0.90;
                        pricedouble = 72 * discount * nightscount;
                    }
                    else
                    {
                        pricedouble = 72 * nightscount;
                    }
                    pricesuite = 82 * nightscount;
                    break;
                case "July":
                case "August":
                case "December":
                    if (nightscount > 14)
                    {
                        double discount = 0.85;
                        pricesuite = 89 * discount * nightscount;
                    }
                    else
                    {
                        pricesuite = 89 * nightscount;
                    }
                    pricedouble = 77 * nightscount;
                    pricestudio = 68 * nightscount;
                    break;
            }
            if (pricestudio + pricedouble + pricesuite != 0)
            {
                Console.WriteLine("Studio: {0:F2} lv.", pricestudio);
                Console.WriteLine("Double: {0:F2} lv.", pricedouble);
                Console.WriteLine("Suite: {0:F2} lv.", pricesuite);
            }
        }
    }
}
