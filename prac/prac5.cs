using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split();

            int x = int.Parse(data[0]);
            int y = int.Parse(data[1]);
            int l = int.Parse(data[2]);
            int c1 = int.Parse(data[3]);
            int c2 = int.Parse(data[4]);
            int c3 = int.Parse(data[5]);
            int c4 = int.Parse(data[6]);
            int c5 = int.Parse(data[7]);
            int c6 = int.Parse(data[8]);

            int perimeter = 2 * (x + y);
            int answer = int.MaxValue;

            for (int repaired = 0;
                 repaired <= Math.Min(l, Math.Max(x, y));
                 repaired++)
            {
                int dismantled = l - repaired;
                int oldUsed = Math.Min(dismantled,
                                       perimeter - repaired);
                int newUsed = perimeter - repaired - oldUsed;
                int waste = dismantled - oldUsed;

                int cost = repaired * c1
                         + dismantled * c2
                         + oldUsed * c3
                         + newUsed * (c4 + c5)
                         + waste * c6;

                answer = Math.Min(answer, cost);
            }

            Console.WriteLine(answer);
        }
    }
}
