using System;

namespace Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string a = $"{i}";
                

                //a = Convert.ToString(a);
                string c = new String(Convert.ToChar(a), i);
                string csp = new String(Convert.ToChar("."), i);
                
                Console.WriteLine($"{c}{csp}");
            }
        }
    }
}
