using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gd8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[10];
            int j = mass.Length - 1;
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                mass[i] = random.Next(0, 10);
            }
            Console.WriteLine(string.Join(", ", mass));
            mass = mass.OrderBy(x => x == 0 ? 1).ToArray();
            Console.WriteLine(string.Join(", ", mass));
        }
    }
}
