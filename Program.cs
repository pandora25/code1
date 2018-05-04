using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = { 1, 3, 4, 6, 8, 10, 20 };
            int count = 0;
            int sum = 0;
            int avarge = 0;
            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] % 2 == 1)
                {
                    count++;
                    sum += Numbers[i];
                }
            }
            avarge = sum / count;
            Console.WriteLine(avarge);
        }
    }
}
