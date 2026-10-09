using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> results = new List<string>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "0")
                    break;

                string[] parts = line.Split(
                    new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length == 0)
                    continue;

                string action = parts[0];
                string start = "";
                string end = "";

                if (action == "MIX")
                {
                    start = "MX";
                    end = "XM";
                }
                else if (action == "WATER")
                {
                    start = "WT";
                    end = "TW";
                }
                else if (action == "DUST")
                {
                    start = "DT";
                    end = "TD";
                }
                else if (action == "FIRE")
                {
                    start = "FR";
                    end = "RF";
                }

                string word = start;

                for (int i = 1; i < parts.Length; i++)
                {
                    string ingredient = parts[i];

                    if (int.TryParse(ingredient, out int number))
                    {
                        if (number >= 1 && number <= results.Count)
                            word += results[number - 1];
                    }
                    else
                    {
                        word += ingredient;
                    }
                }

                word += end;
                results.Add(word);
            }

            if (results.Count > 0)
                Console.WriteLine(results[results.Count - 1]);
        }
    }
}
