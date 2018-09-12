using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            int sum = 0;
            for(int i = 0;i<array.Length;i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                sum += array[i];
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
