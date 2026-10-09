using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long maxN = long.Parse(Console.ReadLine());
            long count = 0;
            long power = 2;

            while (power - 1 <= maxN)
            {
                count += maxN / (power - 1);
                power *= 2;
            }

            Console.WriteLine(count);
        }
    }
}
