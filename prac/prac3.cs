using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static int CountGroups(int n)
        {
            if (n < 3)
                return 0;

            if (n == 3)
                return 1;

            int odd = (n + 1) / 2;
            int even = n / 2;

            return CountGroups(odd) + CountGroups(even);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество солдат: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(CountGroups(n));
        }
    }
}
