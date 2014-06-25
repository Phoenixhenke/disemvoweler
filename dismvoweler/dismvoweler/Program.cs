using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dismvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            string vowels = "aeiou";

            Console.WriteLine("Insert string to be dismvoweler");
            string input = Console.ReadLine();
            char[] removed = new char[50];
            int count = 0;
            for (int p = 0; p < input.Length; p++)
            {
                if (input[p] == 'a' || input[p] == 'e' || input[p] == 'i' || input[p] == 'o' || input[p] == 'u')
                    removed[count] = input[p];
                count++;
            }
             string step1 = input.Replace(" ",string.Empty);
             step1 = step1.Replace("a", string.Empty);
             step1 = step1.Replace("e", string.Empty);
             step1 = step1.Replace("i", string.Empty);
             step1 = step1.Replace("o", string.Empty);
             step1 = step1.Replace("u", string.Empty);

             Console.WriteLine("output: " + step1 + "\n");
             Console.WriteLine("and");
            Console.WriteLine("removed: " + new string(removed));

            Console.ReadKey(true);
        }
    }
}