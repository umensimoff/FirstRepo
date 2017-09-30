using System;

namespace Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnumber = int.Parse(Console.ReadLine());
            int lastnumber = int.Parse(Console.ReadLine());

            int min = Math.Min(firstnumber,lastnumber);
            int max = Math.Max(firstnumber, lastnumber);
            for (int i = min; i <=max; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
