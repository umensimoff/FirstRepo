using System;
using System.Runtime.InteropServices;

namespace Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 99; i++)
            {
                try
                {
                    var input = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
